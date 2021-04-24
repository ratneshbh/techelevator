using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
    public class AccountSqlDAO : IAccountSqlDAO
    {
        private readonly string connectionString;
        public AccountSqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }
        public Account AccountBalance(int userId)     //userId rather than user to make TransferTo easier
        {
            Account account = new Account();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT account_id, user_id, balance FROM accounts WHERE user_id = @user_id;", conn);
                    cmd.Parameters.AddWithValue("@user_id", userId); 
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        account = AccountFromReader(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return account;
        }
       
        public List<Account> ListUsers()        //list of all users
        {
            List<Account> accounts = new List<Account>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT account_id, user_id, balance FROM accounts", conn);  //getting all account data
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        accounts.Add(AccountFromReader(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return accounts;
        }
            
        public bool TransferTo(decimal amount, int userId, int recipientId)   //login gives userId, not entire profile of user 
        {
            if (AccountBalance(userId).Balance < amount||amount<=0) //lower limit of when can transfer
            {
                return false;
            }
            else 
            {
                decimal remainingBalance = AccountBalance(userId).Balance - amount; //checks amount and reduces balance
                decimal recipientAddedBalance = AccountBalance(recipientId).Balance + amount; //checks amount and adds balance
                try
                {
                    using (SqlConnection conn = new SqlConnection (connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE accounts SET balance=@remainingBalance WHERE user_id=@user_Id; UPDATE accounts SET balance=@recipientAddedBalance WHERE user_id=@recipientId", conn);
                        cmd.Parameters.AddWithValue("@remainingBalance", remainingBalance);
                        cmd.Parameters.AddWithValue("@user_id", userId);
                        cmd.Parameters.AddWithValue("@recipientAddedBalance", recipientAddedBalance);
                        cmd.Parameters.AddWithValue("@recipientId", recipientId);
                        cmd.ExecuteNonQuery();  //no reader because not reading, we updated the data
                        return true;
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Issues updating database. Try again");
                }
            }

        }

        private Account AccountFromReader(SqlDataReader reader)
        {
            Account account = new Account();
            account.AccountId = Convert.ToInt32(reader["account_id"]);
            account.UserId = Convert.ToInt32(reader["user_id"]);
            account.Balance = Convert.ToDecimal(reader["balance"]);
            return account;
        }
    }
}

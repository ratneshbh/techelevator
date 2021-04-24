using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAO : ILanguageDAO
    {
        private readonly string connectionString;

        /// <summary>
        /// Creates a sql based language dao.
        /// </summary>
        /// <param name="databaseConnectionString"></param>
        public LanguageSqlDAO(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public IList<Language> GetLanguages(string countryCode)
        {
            throw new NotImplementedException();
        }
        //change to update from insert
        public bool AddNewLanguage(Language newLanguage)
        {
            int rowsAffected;

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {

                    sqlConn.Open();
                    string sql = "UPDATE countrylanguage SET percentage = @percentage WHERE countrycode = @countrycode AND language = @language";
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                    sqlCmd.Parameters.AddWithValue("@countrycode", newLanguage.CountryCode);
                    sqlCmd.Parameters.AddWithValue("@language", newLanguage.Name);
                    sqlCmd.Parameters.AddWithValue("@isofficial", newLanguage.IsOfficial);
                    sqlCmd.Parameters.AddWithValue("@percentage", newLanguage.Percentage);

                    rowsAffected = sqlCmd.ExecuteNonQuery();                   

                }
            }
            catch (Exception)
            {

                throw;
            }

            return (rowsAffected > 0);

        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            int rowsAffected;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM countrylanguage WHERE countrycode = @countrycode AND language = @language;", conn);
                    cmd.Parameters.AddWithValue("@countrycode", deadLanguage.CountryCode);
                    cmd.Parameters.AddWithValue("@language", deadLanguage.Name);
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return (rowsAffected > 0);

        }
    }
}

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public BankAccount(string accountHolderName, string accountNumber) { }  //constructor

        public BankAccount(string accountHolderName, string accountNumber, decimal balance) 
        {
            
            this.Balance = balance;  //balance is initialized to the dollar balance given
        } 

        public string AccountHolderName { get; private set; } // property - returns account holder name

        public string AccountNumber { get; set; }  //property - returns the account number - get { return baseClassVariable; }

        public decimal Balance { get; private set; }  //property - returns the account balance value in USD

        public decimal Deposit(decimal amountToDeposit) 
        {
            Balance = amountToDeposit + Balance;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance = Balance - amountToWithdraw;
            return Balance;
        }




    }
}

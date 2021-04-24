namespace BankTellerExercise
{
    public class BankAccount : IAccountable 
    {
        
        public BankAccount() : base() { }
        public int TransferTo(BankAccount destinationAccount, int transferAmount)
        {
            //this deposits to the wrong account - where we should be withdrawing. Deposit(transferAmount); 
            Withdraw(transferAmount);
            destinationAccount.Deposit(transferAmount);      //this deposits into the destinationAccount 
            return transferAmount;
        }

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; private set; }
        public int Balance { get; private set; }

        public BankAccount(string accountHolder, string accountNumber)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public BankAccount(string accountHolder, string accountNumber, int balance)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int Deposit(int amountToDeposit)  //this is a method particular to each instance 
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual int Withdraw(int amountToWithdraw)  //this is a method particular to each instance
        {
            Balance -= amountToWithdraw;
            return Balance;
        }
    }
}

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount  //same issue as Step 2 - BA does not contain a constructor that takes 0 arguments
    {
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber) { }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) { }
        
            public override decimal Withdraw(decimal amountToWithdraw) {


            if (Balance - amountToWithdraw >= 2) //if balance is at least 2 bucks more than would be withdrawn
            {
                base.Withdraw(amountToWithdraw);
                
                if (Balance < 150)
                {
                    base.Withdraw(2M);       //literal suffix - 2M - M is for the decimal type
                }
                
            }
            return Balance;
            }
        

        //constructor method required? 
        // if (Balance < 150)
        //    {Balance = Balance - Withdrawal - 2.00; }
        // else (Balance < Withdrawal)
        //  {return Balance };

    }
}

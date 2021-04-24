namespace BankTellerExercise.Classes
{
    abstract public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber) { } 

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) { }

        public override decimal Withdraw(decimal amountToWithdraw)
        { //if balance is less than 0 && balance is less than -100, then balance = balance less withdrawal less 10 fee 
            //if amountToWithdraw >= 100, Balance = Balance 
            base.Withdraw(amountToWithdraw);
            if (Balance - amountToWithdraw < -100 && Balance < 0)
            { 
                            //use Withdraw method from base class to get Balance less withdrawal
            
                return base.Withdraw(amountToWithdraw) - 10;  //10 fee charged
            }
            else if ( Balance - amountToWithdraw >= -100 && Balance < 0)   //if a withdrawal leaves the account $100 or more overdrawn: amountToWithdraw >= Balanc
            {
                return base.Withdraw(amountToWithdraw) - 10; //-109
            }
            
            
            return Balance;
            
            
        }
    }
}

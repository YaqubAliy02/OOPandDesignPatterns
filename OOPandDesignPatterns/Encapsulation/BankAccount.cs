namespace OOPandDesignPatterns.Encapsulation
{
    internal class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal amount)
        {
            Deposit(amount);
        }

        public decimal Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Amount must be positive during add money");

            return balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public decimal DrawBack(decimal amount)
        {
            if(amount < 0) throw new ArgumentException("Amount must be positive during drawing back");

            if (balance < amount) throw new Exception("Amount must be less then balance");

            return balance -= amount;
        }
    }
}

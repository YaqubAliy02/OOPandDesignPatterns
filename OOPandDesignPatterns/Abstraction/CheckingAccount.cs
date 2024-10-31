namespace OOPandDesignPatterns.Abstraction
{
    internal class CheckingAccount : Account
    {
        private const decimal OverdraftLimit = 100;
        public override void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Amount must be positive");

            Balance += amount;
        }

        public override void WithDraw(decimal amount)
        {
            if (amount <= Balance + OverdraftLimit)
                Balance -= amount;

            else
                throw new InvalidOperationException("Insufficient funds, including overdraft limit.");
        }
    }

    internal class SavingsAccount : Account
    {
        private const decimal MinimumBalance = 50;

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void WithDraw(decimal amount)
        {
            if (Balance - amount >= MinimumBalance)
                Balance -= amount;

            else
                throw new InvalidOperationException("Insufficient funds, minimum balance required");
        }
    }
}

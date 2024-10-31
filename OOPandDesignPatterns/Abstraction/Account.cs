namespace OOPandDesignPatterns.Abstraction
{
    internal abstract class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        protected decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void WithDraw(decimal amount);

        public decimal GetBalance()
        {
            return Balance;
        }

    }
}

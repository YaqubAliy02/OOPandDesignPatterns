namespace OOPandDesignPatterns.SOLID.O.Solution
{
    internal class Ground : IShipping
    {
        public double GetCost(Order order)
        {
            if (order.GetTotal > 100) return 0;

            return Math.Max(10, order.GetTotalWeight * 1.5);
        }
    }
}

namespace OOPandDesignPatterns.SOLID.O.Solution
{
    internal class Air : IShipping
    {
        public double GetCost(Order order)
        {
            if (order.GetTotal > 100) return 0;

            return Math.Max(20, order.GetTotalWeight * 3);
        }
    }
}

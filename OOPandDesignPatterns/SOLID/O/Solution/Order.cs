namespace OOPandDesignPatterns.SOLID.O.Solution
{
    internal class Order
    {
        private int LineItems { get; set; }
        private string Shipping { get; set; }
        public double GetTotal { get; set; }
        public int GetTotalWeight { get; set; }
        public IShipping shipping { get; set; }

        public double GetShippingCost()
        {
            return shipping.GetCost(this); 
        }

    }
}

/*
 You have an e-commerce application with an
 Order class that
 calculates shipping costs and all shipping methods are hard
coded inside the class. If you need to add a new shipping
 method, you have to change the code of the
 Order class and
 risk breaking it
 */

namespace OOPandDesignPatterns.SOLID.O.Problem
{
    internal class Order
    {
        private int LineItems { get; set; }
        private string Shipping { get; set; }
        private double GetTotal { get; set; }
        private int GetTotalWeight { get; set; }

        public double GetShippingCost()
        {
            if (Shipping == "Ground")
            {
                if (GetTotal > 100)
                {
                    return 0;
                }
                return Math.Max(10, GetTotalWeight * 1.5);
            }

            if (Shipping == "Air")
            {
                return Math.Max(20, GetTotalWeight * 3);
            }

            return GetTotal;
        }

    }
}

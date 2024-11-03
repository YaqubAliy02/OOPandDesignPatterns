namespace OOPandDesignPatterns.SOLID.I.Solution
{
    internal class Circle : IShape2D
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}

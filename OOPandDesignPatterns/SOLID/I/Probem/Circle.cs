namespace OOPandDesignPatterns.SOLID.I.Probem
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            throw new InvalidOperationException("Valume is not applicable for 2D shapes");
        }
    }
}

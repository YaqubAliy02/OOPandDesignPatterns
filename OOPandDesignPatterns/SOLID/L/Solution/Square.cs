namespace OOPandDesignPatterns.SOLID.L.Solution
{
    internal class Square : Shape
    {
        public int SideLength { get; set; }
        public override double Area => SideLength * SideLength;
    }
}

﻿namespace OOPandDesignPatterns.SOLID.L.Solution
{
    internal class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public override double Area => Width * Height;

    }
}

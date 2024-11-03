namespace OOPandDesignPatterns.SOLID.D.Solution
{
    internal class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            Console.WriteLine("Car started");
        }
    }
}

namespace OOPandDesignPatterns.SOLID.D.Problem
{
    internal class Car
    {
        private Engine engine;

        public Car()
        {
            this.engine = new Engine();
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}

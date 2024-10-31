namespace OOPandDesignPatterns.Inheritance
{
    internal class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Vehicle: {Make} {Model}, Year: {Year} ");
        }
    }
}

namespace OOPandDesignPatterns.SOLID.S.Solution
{
    internal class Employee
    {
        private string Name { get; set; }

        public void GetName()
        {
            Console.WriteLine("Employee name: " + Name);
        }
    }
}

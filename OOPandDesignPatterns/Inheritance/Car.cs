using Microsoft.VisualBasic;

namespace OOPandDesignPatterns.Inheritance
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void LockDoor()
        {
            Console.WriteLine("Doors is locked");
        }
    }
}

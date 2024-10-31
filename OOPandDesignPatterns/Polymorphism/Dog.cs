namespace OOPandDesignPatterns.Polymorphism
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override void Eat()
        {
            Console.WriteLine("The dog eats kibble.");
        }

    }
}

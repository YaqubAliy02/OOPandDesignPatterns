namespace OOPandDesignPatterns.Polymorphism
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("the cat eats fish.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}

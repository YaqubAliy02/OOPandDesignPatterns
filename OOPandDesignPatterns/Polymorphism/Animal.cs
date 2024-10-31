namespace OOPandDesignPatterns.Polymorphism
{
    internal abstract class Animal
    {
        public abstract void Eat();

        public virtual void MakeSound()
        {
            Console.WriteLine("Some animal sound.");
        }
    }
}

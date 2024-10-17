namespace LiskovSubstitutionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle(LSP): " +
                "Derived classes must be able to replace the base class and must not disrupt the behavior of the base class.");
        }
    }

    // The Penguin_Wrong class cannot implement the Fly method of the Bird class,
    // Penguin objects cannot substitute for Bird objects, and this violates the LSP.
    public class Penguin_Wrong : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins can't fly!");
        }
    }

    // Both classes implement the IBird interface, but their movement capabilities differ.
    // This preserves the LSP and allows using both types as IBird.
    public class Sparrow : IBird
    {
        public void Move()
        {
            // Uçma kodu
        }
    }

    public class Penguin_Correct : IBird
    {
        public void Move()
        {
            // Yürüyüş kodu
        }
    }
}

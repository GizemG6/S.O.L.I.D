namespace OpenClosedPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open/Closed Principle(OCP): A class should be open to extension but closed to modification.");
        }
    }
    public class Run
    {
        public void Print()
        {
            Console.WriteLine("Open/Closed Principle(OCP): A class should be open to extension but closed to modification.");
        }
    }
    public class Circle : IShape
    {
        public double _radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class AreaCalculator_Correct
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }

    // The AreaCalculator_Correct class is open to be extended without modification to add new shapes, just using the IShape interface.
}

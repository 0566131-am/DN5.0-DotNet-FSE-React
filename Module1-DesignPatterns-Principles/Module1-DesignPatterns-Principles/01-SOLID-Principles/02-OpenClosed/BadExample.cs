// OCP - VIOLATION
// To support a new shape, we must MODIFY AreaCalculator's existing code (if/else chain).
using System;

namespace OCP.Bad
{
    public class Rectangle
    {
        public double Width;
        public double Height;
    }

    public class Circle
    {
        public double Radius;
    }

    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Rectangle r)
                return r.Width * r.Height;
            else if (shape is Circle c)
                return Math.PI * c.Radius * c.Radius;
            // Adding a Triangle means editing THIS method again.
            throw new ArgumentException("Unknown shape");
        }
    }

    class Program
    {
        static void Main()
        {
            var calc = new AreaCalculator();
            Console.WriteLine(calc.CalculateArea(new Rectangle { Width = 4, Height = 5 }));
            Console.WriteLine(calc.CalculateArea(new Circle { Radius = 3 }));
        }
    }
}

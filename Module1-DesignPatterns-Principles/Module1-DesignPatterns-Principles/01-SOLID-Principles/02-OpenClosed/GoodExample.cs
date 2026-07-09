// OCP - FIXED
// New shapes can be ADDED without touching AreaCalculator at all.
using System;
using System.Collections.Generic;

namespace OCP.Good
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width, Height;
        public override double Area() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius;
        public override double Area() => Math.PI * Radius * Radius;
    }

    // New shape - no existing code changed!
    public class Triangle : Shape
    {
        public double Base, Height;
        public override double Area() => 0.5 * Base * Height;
    }

    public class AreaCalculator
    {
        public double TotalArea(IEnumerable<Shape> shapes)
        {
            double total = 0;
            foreach (var shape in shapes)
                total += shape.Area();
            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Rectangle { Width = 4, Height = 5 },
                new Circle { Radius = 3 },
                new Triangle { Base = 6, Height = 4 }
            };

            var calc = new AreaCalculator();
            Console.WriteLine($"Total area: {calc.TotalArea(shapes)}");
        }
    }
}

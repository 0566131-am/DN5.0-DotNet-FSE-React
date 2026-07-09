// FACTORY METHOD PATTERN
// Delegates object creation to a factory, so client code depends on an
// abstraction (IShape) rather than concrete classes.
using System;

namespace Patterns.Creational.FactoryMethod
{
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Circle");
    }

    public class Square : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Square");
    }

    public class Triangle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Triangle");
    }

    public static class ShapeFactory
    {
        public static IShape CreateShape(string shapeType)
        {
            return shapeType.ToLower() switch
            {
                "circle" => new Circle(),
                "square" => new Square(),
                "triangle" => new Triangle(),
                _ => throw new ArgumentException($"Unknown shape type: {shapeType}")
            };
        }
    }

    class Program
    {
        static void Main()
        {
            IShape shape1 = ShapeFactory.CreateShape("circle");
            IShape shape2 = ShapeFactory.CreateShape("square");

            shape1.Draw();
            shape2.Draw();
        }
    }
}

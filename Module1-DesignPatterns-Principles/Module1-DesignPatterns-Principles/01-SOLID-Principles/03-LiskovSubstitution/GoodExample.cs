// LSP - FIXED
// Split flight capability into its own abstraction. Only birds that CAN fly implement it.
using System;
using System.Collections.Generic;

namespace LSP.Good
{
    public abstract class Bird
    {
        public abstract void Eat();
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : Bird, IFlyable
    {
        public override void Eat() => Console.WriteLine("Sparrow eating seeds.");
        public void Fly() => Console.WriteLine("Sparrow flying high!");
    }

    public class Penguin : Bird
    {
        // No Fly() to break - Penguin never promises flight.
        public override void Eat() => Console.WriteLine("Penguin eating fish.");
        public void Swim() => Console.WriteLine("Penguin swimming gracefully.");
    }

    class Program
    {
        static void Main()
        {
            List<Bird> birds = new() { new Sparrow(), new Penguin() };
            foreach (var bird in birds)
            {
                bird.Eat();
                if (bird is IFlyable flyable)
                    flyable.Fly();
            }
        }
    }
}

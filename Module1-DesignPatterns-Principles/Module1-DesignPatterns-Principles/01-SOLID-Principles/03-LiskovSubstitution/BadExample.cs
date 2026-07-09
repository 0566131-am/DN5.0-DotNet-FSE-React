// LSP - VIOLATION
// Penguin IS-A Bird, but cannot Fly(). Substituting Penguin where Bird is expected breaks behavior.
using System;
using System.Collections.Generic;

namespace LSP.Bad
{
    public class Bird
    {
        public virtual void Fly() => Console.WriteLine("Flying high!");
    }

    public class Sparrow : Bird { }

    public class Penguin : Bird
    {
        // Penguins can't fly - forced to violate the contract of the base class.
        public override void Fly() => throw new NotSupportedException("Penguins can't fly!");
    }

    class Program
    {
        static void Main()
        {
            List<Bird> birds = new() { new Sparrow(), new Penguin() };
            foreach (var bird in birds)
            {
                bird.Fly(); // Crashes when it hits the Penguin
            }
        }
    }
}

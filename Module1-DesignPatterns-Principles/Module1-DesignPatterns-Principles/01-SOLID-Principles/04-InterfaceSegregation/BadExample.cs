// ISP - VIOLATION
// IWorker forces ALL workers to implement Eat(), even Robots which don't eat.
using System;

namespace ISP.Bad
{
    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class HumanWorker : IWorker
    {
        public void Work() => Console.WriteLine("Human working...");
        public void Eat() => Console.WriteLine("Human eating lunch...");
    }

    public class RobotWorker : IWorker
    {
        public void Work() => Console.WriteLine("Robot working...");
        // Forced to implement something meaningless for a robot.
        public void Eat() => throw new NotSupportedException("Robots don't eat!");
    }

    class Program
    {
        static void Main()
        {
            IWorker robot = new RobotWorker();
            robot.Work();
            robot.Eat(); // Throws - design smell
        }
    }
}

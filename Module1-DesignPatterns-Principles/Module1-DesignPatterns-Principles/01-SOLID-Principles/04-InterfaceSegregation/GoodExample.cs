// ISP - FIXED
// Split into smaller, role-specific interfaces. Clients only implement what they need.
using System;

namespace ISP.Good
{
    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();
    }

    public class HumanWorker : IWorkable, IFeedable
    {
        public void Work() => Console.WriteLine("Human working...");
        public void Eat() => Console.WriteLine("Human eating lunch...");
    }

    public class RobotWorker : IWorkable
    {
        // Only implements what is relevant to it.
        public void Work() => Console.WriteLine("Robot working...");
    }

    class Program
    {
        static void Main()
        {
            IWorkable robot = new RobotWorker();
            robot.Work();

            IWorkable human = new HumanWorker();
            human.Work();
            if (human is IFeedable feedable)
                feedable.Eat();
        }
    }
}

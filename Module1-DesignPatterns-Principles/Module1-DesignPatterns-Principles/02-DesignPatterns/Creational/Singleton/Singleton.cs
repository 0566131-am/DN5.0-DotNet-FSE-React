// SINGLETON PATTERN
// Ensures a class has only ONE instance, with global access to it.
// Common use case: Logger, Configuration Manager, Connection Pool.
using System;

namespace Patterns.Creational.Singleton
{
    public sealed class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new();

        // Private constructor prevents external instantiation
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public static Logger Instance
        {
            get
            {
                // Thread-safe lazy initialization
                lock (_lock)
                {
                    _instance ??= new Logger();
                    return _instance;
                }
            }
        }

        public void Log(string message) =>
            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {message}");
    }

    class Program
    {
        static void Main()
        {
            Logger.Instance.Log("Application started.");

            var sameLogger = Logger.Instance;
            sameLogger.Log("Processing request...");

            Console.WriteLine($"Same instance? {ReferenceEquals(Logger.Instance, sameLogger)}");
        }
    }
}

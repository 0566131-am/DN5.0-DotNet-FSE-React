// SRP - VIOLATION
// This single class has THREE responsibilities: validating, saving to DB, and sending email.
// Any change to email logic forces a change/recompile of the same class that handles persistence.
using System;

namespace SRP.Bad
{
    public class UserManager
    {
        public void RegisterUser(string name, string email)
        {
            // Responsibility 1: Validation
            if (string.IsNullOrWhiteSpace(name) || !email.Contains("@"))
            {
                Console.WriteLine("Invalid user data.");
                return;
            }

            // Responsibility 2: Persistence
            Console.WriteLine($"Saving {name} to database...");

            // Responsibility 3: Notification
            Console.WriteLine($"Sending welcome email to {email}...");
        }
    }

    class Program
    {
        static void Main()
        {
            var manager = new UserManager();
            manager.RegisterUser("Mubeena", "mubeena@example.com");
        }
    }
}

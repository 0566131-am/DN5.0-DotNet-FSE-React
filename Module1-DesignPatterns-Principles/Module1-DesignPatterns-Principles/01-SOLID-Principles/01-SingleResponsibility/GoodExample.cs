// SRP - FIXED
// Each class now has exactly ONE reason to change.
using System;

namespace SRP.Good
{
    public class UserValidator
    {
        public bool IsValid(string name, string email) =>
            !string.IsNullOrWhiteSpace(name) && email.Contains("@");
    }

    public class UserRepository
    {
        public void Save(string name) =>
            Console.WriteLine($"Saving {name} to database...");
    }

    public class EmailService
    {
        public void SendWelcomeEmail(string email) =>
            Console.WriteLine($"Sending welcome email to {email}...");
    }

    public class UserManager
    {
        private readonly UserValidator _validator = new();
        private readonly UserRepository _repository = new();
        private readonly EmailService _emailService = new();

        public void RegisterUser(string name, string email)
        {
            if (!_validator.IsValid(name, email))
            {
                Console.WriteLine("Invalid user data.");
                return;
            }

            _repository.Save(name);
            _emailService.SendWelcomeEmail(email);
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

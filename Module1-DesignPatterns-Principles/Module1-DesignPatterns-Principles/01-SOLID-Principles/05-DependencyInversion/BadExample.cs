// DIP - VIOLATION
// NotificationService is tightly coupled to the concrete EmailSender.
// Switching to SMS later means editing NotificationService's source code.
using System;

namespace DIP.Bad
{
    public class EmailSender
    {
        public void Send(string message) => Console.WriteLine($"Email sent: {message}");
    }

    public class NotificationService
    {
        private readonly EmailSender _emailSender = new(); // Hard-coded dependency

        public void Notify(string message) => _emailSender.Send(message);
    }

    class Program
    {
        static void Main()
        {
            var service = new NotificationService();
            service.Notify("Your order has shipped!");
        }
    }
}

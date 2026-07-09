// DIP - FIXED
// High-level NotificationService depends on an ABSTRACTION (IMessageSender),
// not a concrete class. New senders can be plugged in via constructor injection.
using System;

namespace DIP.Good
{
    public interface IMessageSender
    {
        void Send(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void Send(string message) => Console.WriteLine($"Email sent: {message}");
    }

    public class SmsSender : IMessageSender
    {
        public void Send(string message) => Console.WriteLine($"SMS sent: {message}");
    }

    public class NotificationService
    {
        private readonly IMessageSender _sender;

        // Dependency Injection via constructor
        public NotificationService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Notify(string message) => _sender.Send(message);
    }

    class Program
    {
        static void Main()
        {
            var emailService = new NotificationService(new EmailSender());
            emailService.Notify("Your order has shipped!");

            var smsService = new NotificationService(new SmsSender());
            smsService.Notify("Your OTP is 4521");
        }
    }
}

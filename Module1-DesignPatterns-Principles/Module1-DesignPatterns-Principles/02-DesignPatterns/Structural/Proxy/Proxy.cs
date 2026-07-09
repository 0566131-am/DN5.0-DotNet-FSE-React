// PROXY PATTERN
// Provides a placeholder/surrogate for another object to control access to it.
// Here, a ProxyImage delays loading the heavy RealImage until it's actually needed (lazy loading).
using System;

namespace Patterns.Structural.Proxy
{
    public interface IImage
    {
        void Display();
    }

    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(); // Expensive operation
        }

        private void LoadFromDisk() =>
            Console.WriteLine($"Loading {_fileName} from disk (expensive operation)...");

        public void Display() => Console.WriteLine($"Displaying {_fileName}");
    }

    public class ProxyImage : IImage
    {
        private RealImage? _realImage;
        private readonly string _fileName;

        public ProxyImage(string fileName) => _fileName = fileName;

        public void Display()
        {
            // RealImage is only created the first time it's actually needed.
            _realImage ??= new RealImage(_fileName);
            _realImage.Display();
        }
    }

    class Program
    {
        static void Main()
        {
            IImage image = new ProxyImage("vacation_photo.png");

            Console.WriteLine("Image object created. Nothing loaded yet.");
            Console.WriteLine("Calling Display() for the first time:");
            image.Display(); // Loads and displays

            Console.WriteLine("Calling Display() again:");
            image.Display(); // Just displays, no reload
        }
    }
}

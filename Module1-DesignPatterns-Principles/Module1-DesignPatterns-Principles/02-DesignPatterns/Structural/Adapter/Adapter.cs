// ADAPTER PATTERN
// Converts the interface of a class into another interface clients expect.
// Here, a legacy XML-based reporting system is adapted to a modern IJsonReport interface.
using System;

namespace Patterns.Structural.Adapter
{
    // Legacy class with an incompatible interface - we cannot/should not modify it.
    public class LegacyXmlReportGenerator
    {
        public string GenerateXmlReport() => "<report><total>1000</total></report>";
    }

    // Target interface expected by modern client code
    public interface IJsonReport
    {
        string GetJsonReport();
    }

    // Adapter bridges LegacyXmlReportGenerator to the IJsonReport interface
    public class XmlToJsonReportAdapter : IJsonReport
    {
        private readonly LegacyXmlReportGenerator _legacyGenerator;

        public XmlToJsonReportAdapter(LegacyXmlReportGenerator legacyGenerator)
        {
            _legacyGenerator = legacyGenerator;
        }

        public string GetJsonReport()
        {
            string xml = _legacyGenerator.GenerateXmlReport();
            // (In a real app you'd actually parse XML -> JSON; simplified here for clarity)
            return $"{{ \"convertedFrom\": \"{xml}\" }}";
        }
    }

    class Program
    {
        static void Main()
        {
            IJsonReport report = new XmlToJsonReportAdapter(new LegacyXmlReportGenerator());
            Console.WriteLine(report.GetJsonReport());
        }
    }
}

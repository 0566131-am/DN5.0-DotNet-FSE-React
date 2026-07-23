namespace DN.Calculator;

/// <summary>
/// Simple calculator used to practice:
/// - Testing return types of methods
/// - Testing void methods (via observable side effects)
/// - Testing methods that throw exceptions
/// - Testing private methods (via InternalsVisibleTo / reflection)
/// </summary>
public class Calculator
{
    private readonly List<string> _history = new();

    public IReadOnlyList<string> History => _history;

    // ---- Return type testing ----
    public int Add(int a, int b)
    {
        var result = a + b;
        LogOperation($"{a} + {b} = {result}");
        return result;
    }

    public double Divide(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            // ---- Exception testing ----
            throw new DivideByZeroException("Denominator cannot be zero.");
        }

        var result = numerator / denominator;
        LogOperation($"{numerator} / {denominator} = {result}");
        return result;
    }

    // ---- Void method testing (assert on side effect: _history) ----
    public void ClearHistory()
    {
        _history.Clear();
    }

    // ---- Private method testing target ----
    // Use InternalsVisibleTo (already configured) + [InternalsVisibleTo] OR
    // reflection to unit test this "private-like" internal helper.
    internal string FormatResult(double value)
    {
        return value.ToString("0.##");
    }

    private void LogOperation(string entry)
    {
        _history.Add(entry);
    }
}

namespace DN.Calculator;

/// <summary>
/// Used to practice "Testing Arrays and Collections" from the NUnit module.
/// </summary>
public static class ArrayHelper
{
    public static int[] GetEvenNumbers(int[] numbers)
    {
        if (numbers is null)
            throw new ArgumentNullException(nameof(numbers));

        return numbers.Where(n => n % 2 == 0).ToArray();
    }

    public static List<int> RemoveDuplicates(List<int> numbers)
    {
        if (numbers is null)
            throw new ArgumentNullException(nameof(numbers));

        return numbers.Distinct().ToList();
    }

    public static int FindMax(IEnumerable<int> numbers)
    {
        var list = numbers?.ToList() ?? throw new ArgumentNullException(nameof(numbers));

        if (list.Count == 0)
            throw new InvalidOperationException("Cannot find max of an empty collection.");

        return list.Max();
    }
}

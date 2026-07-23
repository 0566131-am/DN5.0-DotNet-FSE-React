namespace DN.Calculator;

/// <summary>
/// Used to practice "Testing Strings" from the NUnit module.
/// </summary>
public static class StringHelper
{
    public static string Reverse(string input)
    {
        if (input is null)
            throw new ArgumentNullException(nameof(input));

        var chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        var normalized = input.Replace(" ", "").ToLowerInvariant();
        return normalized == Reverse(normalized);
    }

    public static string ToTitleCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = char.ToUpperInvariant(words[i][0]) + words[i][1..].ToLowerInvariant();
        }

        return string.Join(' ', words);
    }
}

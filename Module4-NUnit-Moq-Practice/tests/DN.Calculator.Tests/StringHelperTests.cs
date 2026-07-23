using DN.Calculator;
using NUnit.Framework;

namespace DN.Calculator.Tests;

[TestFixture]
public class StringHelperTests
{
    // ---------------------------------------------------------------
    // EXERCISE 1: Testing strings
    // Reverse("hello") should return "olleh"
    // ---------------------------------------------------------------
    [Test]
    public void Reverse_SimpleWord_ReturnsReversedString()
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 2: Testing a method that throws on null input
    // Reverse(null) should throw ArgumentNullException
    // ---------------------------------------------------------------
    [Test]
    public void Reverse_NullInput_ThrowsArgumentNullException()
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 3: Parameterized boolean test
    // IsPalindrome("Racecar") -> true
    // IsPalindrome("hello") -> false
    // IsPalindrome("") -> false
    // Add [TestCase] rows for each scenario.
    // ---------------------------------------------------------------
    [TestCase("Racecar", true)]
    // TODO: add more TestCase rows
    public void IsPalindrome_VariousInputs_ReturnsExpected(string input, bool expected)
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 4: Ignoring a test (Writing Trustworthy Tests / Ignoring Tests)
    // Practice marking a test as ignored with a reason, then un-ignore
    // it once you've implemented ToTitleCase correctly.
    // ---------------------------------------------------------------
    [Test]
    [Ignore("TODO: remove this Ignore attribute once implemented")]
    public void ToTitleCase_MultipleWords_CapitalizesEachWord()
    {
        // TODO: implement this test for "hello world" -> "Hello World"
        Assert.Fail("TODO: implement this test");
    }
}

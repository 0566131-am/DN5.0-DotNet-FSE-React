using DN.Calculator;
using NUnit.Framework;

namespace DN.Calculator.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator = null!;

    // Set Up and Tear Down
    [SetUp]
    public void SetUp()
    {
        _calculator = new Calculator();
    }

    [TearDown]
    public void TearDown()
    {
        _calculator = null!;
    }

    // ---------------------------------------------------------------
    // EXERCISE 1: Testing return type of a method
    // Write a test that calls Add(2, 3) and asserts the result is 5.
    // ---------------------------------------------------------------
    [Test]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // TODO: Arrange, Act, Assert
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 2: Parameterized test using [TestCase]
    // Add at least 3 more [TestCase] rows covering negative numbers
    // and zero.
    // ---------------------------------------------------------------
    [TestCase(2, 3, 5)]
    // TODO: add more TestCase attributes here
    public void Add_MultipleInputs_ReturnsExpectedSum(int a, int b, int expected)
    {
        // TODO: Act + Assert using the parameters above
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 3: Testing methods that throw exceptions
    // Divide(10, 0) should throw a DivideByZeroException.
    // Use Assert.Throws<T>(...) 
    // ---------------------------------------------------------------
    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // TODO: implement using Assert.Throws<DivideByZeroException>
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 4: Testing void methods via observable side effects
    // 1. Call Add(1,1) then Divide(4,2) so History has 2 entries.
    // 2. Call ClearHistory().
    // 3. Assert _calculator.History.Count is 0.
    // ---------------------------------------------------------------
    [Test]
    public void ClearHistory_AfterOperations_EmptiesHistory()
    {
        // TODO: implement this test
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 5: Testing a private/internal method
    // FormatResult is internal (visible here via InternalsVisibleTo).
    // Test that FormatResult(3.14159) returns "3.14".
    // ---------------------------------------------------------------
    [Test]
    public void FormatResult_RoundsToTwoDecimals()
    {
        // TODO: implement this test
        Assert.Fail("TODO: implement this test");
    }
}

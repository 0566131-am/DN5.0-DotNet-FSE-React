using DN.Calculator;
using NUnit.Framework;

namespace DN.Calculator.Tests;

[TestFixture]
public class ArrayHelperTests
{
    // ---------------------------------------------------------------
    // EXERCISE 1: Testing arrays
    // GetEvenNumbers(new[] {1,2,3,4,5,6}) should return {2,4,6}
    // Hint: use CollectionAssert.AreEqual or Assert.That(..., Is.EqualTo(...))
    // ---------------------------------------------------------------
    [Test]
    public void GetEvenNumbers_MixedArray_ReturnsOnlyEvens()
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 2: Testing collections (List<T>)
    // RemoveDuplicates([1,1,2,3,3,3]) should return [1,2,3]
    // ---------------------------------------------------------------
    [Test]
    public void RemoveDuplicates_ListWithDuplicates_ReturnsDistinctValues()
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 3: Testing an empty collection edge case + exception
    // FindMax(new List<int>()) should throw InvalidOperationException
    // ---------------------------------------------------------------
    [Test]
    public void FindMax_EmptyCollection_ThrowsInvalidOperationException()
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 4: Testing null input
    // GetEvenNumbers(null) should throw ArgumentNullException
    // ---------------------------------------------------------------
    [Test]
    public void GetEvenNumbers_NullArray_ThrowsArgumentNullException()
    {
        Assert.Fail("TODO: implement this test");
    }
}

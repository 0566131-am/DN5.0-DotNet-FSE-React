// Exercise 6: Exception Handling & Nullable Types
// Concepts: try-catch-finally, custom exceptions, exception filters
// (when), null-coalescing/-conditional operators, required modifier

using System;

// TODO 1: Define a custom exception InsufficientFundsException with a
// message and a decimal ShortfallAmount property.
class InsufficientFundsException : Exception
{
    // TODO: implement
}

// TODO 2: Define a class Order with a required modifier on a property
// (e.g. required string CustomerName) - C# 12 feature that forces
// callers to set it via object initializer.
class Order
{
    // TODO: implement, e.g. public required string CustomerName { get; set; }
}

class Program
{
    static void Main()
    {
        // TODO 3: Write a try/catch/finally block around code that
        // deliberately divides by zero or accesses an out-of-range
        // array index, and print a friendly message plus "cleanup done"
        // in finally.


        // TODO 4: Throw and catch your InsufficientFundsException,
        // reading its ShortfallAmount in the catch block.


        // TODO 5: Use an exception filter with 'when', e.g.
        // catch (Exception ex) when (ex.Message.Contains("specific"))
        // to only catch exceptions matching a condition.


        // TODO 6: Demonstrate null-conditional (?.) and null-coalescing
        // (??) operators on a nullable string, e.g.:
        // string? name = null;
        // int length = name?.Length ?? 0;


        // TODO 7: Create an Order using an object initializer that sets
        // the required CustomerName property (and note what happens if
        // you forget to set it - compiler error).
    }
}

// Exercise 5: Records and Structs
// Concepts: value equality, immutability, records, with-expressions,
// struct improvements

using System;

// TODO 1: Define a record Point(double X, double Y). Create two
// instances with the same values and demonstrate that record equality
// compares VALUES, not references (unlike a plain class).
record Point(double X, double Y);

// TODO 2: Using a Point instance, use a with-expression to create a
// modified copy (e.g. move X but keep Y) without mutating the original.

// TODO 3: Define a struct Coordinate3D with X, Y, Z fields (or use
// C# 12 primary constructor syntax for structs: struct Coordinate3D(double X, double Y, double Z);)
// and show that assigning one struct to another COPIES the value
// (changing the copy doesn't affect the original) - contrast this
// with class/record reference semantics.
struct Coordinate3D
{
    // TODO: implement
}

class Program
{
    static void Main()
    {
        // TODO 4: Demonstrate Point equality (p1 == p2 for two records
        // with identical values should be true).


        // TODO 5: Demonstrate the with-expression from TODO 2.


        // TODO 6: Demonstrate struct copy semantics from TODO 3.
    }
}

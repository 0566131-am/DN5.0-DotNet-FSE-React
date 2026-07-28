// Exercise 4: Inheritance and Polymorphism
// Concepts: base classes, base keyword, virtual/override, abstract
// classes, interfaces

using System;
using System.Collections.Generic;

// TODO 1: Define an abstract class Shape with an abstract method
// double Area() and a virtual method void Describe() that prints
// the shape's area (override Describe in at least one subclass).
abstract class Shape
{
    // TODO: implement
}

// TODO 2: Define classes Circle : Shape and Rectangle : Shape that
// implement Area() appropriately (store radius / width & height,
// pass them via constructors, use base() if useful).
class Circle : Shape
{
    // TODO: implement
}

class Rectangle : Shape
{
    // TODO: implement
}

// TODO 3: Define an interface IPayable with a method decimal GetPayment().
// Implement it on a new class Employee (with base salary logic) and a
// class Contractor (with hourly rate * hours logic).
interface IPayable
{
    // TODO: implement
}

class Program
{
    static void Main()
    {
        // TODO 4: Create a List<Shape> containing a Circle and a
        // Rectangle, then loop through and call Describe() on each -
        // demonstrating polymorphism (same call, different behavior).


        // TODO 5: Create a List<IPayable> with an Employee and a
        // Contractor, and print each one's GetPayment() result.
    }
}

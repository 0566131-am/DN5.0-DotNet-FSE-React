// Exercise 3: OOP - Classes, Constructors, Encapsulation
// Concepts: classes/objects, constructors (incl. primary constructors in
// C# 12), access modifiers, auto-implemented properties, init-only setters

using System;

// TODO 1: Define a class BankAccount with:
//   - private field _balance
//   - public property Balance (read-only from outside, settable internally)
//   - a constructor(string ownerName, decimal openingBalance)
//   - methods Deposit(decimal amount) and Withdraw(decimal amount) that
//     validate amounts and throw if withdrawal exceeds balance
class BankAccount
{
    // TODO: implement
}

// TODO 2: Define a class Student using a C# 12 primary constructor,
// e.g. class Student(string name, int rollNo) { ... }
// Add an auto-implemented property GPA with a normal setter, and an
// init-only property AdmissionYear (settable only at construction time).
class Student
{
    // TODO: implement
}

class Program
{
    static void Main()
    {
        // TODO 3: Create a BankAccount, deposit and withdraw, and print
        // the resulting balance. Try to withdraw more than the balance
        // and observe/handle the exception (try/catch, or just for now
        // let it throw and inspect the message).


        // TODO 4: Create a Student instance using the primary constructor
        // syntax and print its details. Attempt to change AdmissionYear
        // after construction and note the compiler error (leave it
        // commented out with an explanation).
    }
}

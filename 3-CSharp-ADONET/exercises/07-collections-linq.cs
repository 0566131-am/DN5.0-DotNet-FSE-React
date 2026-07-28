// Exercise 7: Collections and LINQ
// Concepts: List, Dictionary, Queue, Stack, foreach iteration,
// LINQ queries for filtering and transformation

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    record Student(string Name, int RollNo, double Marks, string Department);

    static void Main()
    {
        var students = new List<Student>
        {
            new("Asha", 1, 78, "CS"),
            new("Ravi", 2, 55, "CS"),
            new("Meera", 3, 92, "ECE"),
            new("Kiran", 4, 40, "ME"),
            new("Divya", 5, 88, "CS"),
        };

        // TODO 1: Use a List<T> - add a new student to 'students' and
        // iterate over the list with foreach, printing each name.


        // TODO 2: Use a Dictionary<string, double> to store
        // department -> average marks, built manually with a loop.


        // TODO 3: Use a Queue<string> to simulate a print queue: enqueue
        // 3 job names, then dequeue and process them one at a time.


        // TODO 4: Use a Stack<int> to reverse a list of numbers by
        // pushing them all then popping them off.


        // TODO 5: LINQ - use .Where() to filter students with Marks >= 60.


        // TODO 6: LINQ - use .Select() to project just the Name and
        // Marks into an anonymous type or a new record.


        // TODO 7: LINQ - use .OrderByDescending() to sort students by
        // Marks, then .Take(2) to get the top 2 performers.


        // TODO 8: LINQ - use .GroupBy() to group students by Department
        // and print each group's average marks (combine with .Average()).


        // TODO 9: LINQ query syntax - rewrite one of the above queries
        // (e.g. TODO 5) using the "from ... where ... select ..." query
        // syntax instead of method syntax, to see both styles.
    }
}

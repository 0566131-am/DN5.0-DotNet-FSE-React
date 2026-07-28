# Module 3 - C# and ADO.NET Practice Exercises

Covers: C# 12 basics & syntax, control flow, functions/methods, OOP
(classes, encapsulation, inheritance, polymorphism), records/structs,
exception handling, nullable types, collections & LINQ, async/await,
multi-threading basics, and ADO.NET data access.

## Structure
This is set up as loose practice files you can run with `dotnet script`,
paste into https://dotnetfiddle.net/ or https://try.dot.net/, or drop into
a fresh console project:

```
dotnet new console -n CSharpPractice
```

- `exercises/01-basics-controlflow.cs`
- `exercises/02-functions-methods.cs`
- `exercises/03-oop-classes.cs`
- `exercises/04-inheritance-polymorphism.cs`
- `exercises/05-records-structs.cs`
- `exercises/06-exceptions-nullable.cs`
- `exercises/07-collections-linq.cs`
- `exercises/08-async-await.cs`
- `exercises/09-multithreading.cs`
- `exercises/10-adonet-basics.cs` – requires a local/remote SQL Server or
  MySQL connection string; uses the DN5 practice schema from Module 2
  (adjust the connection string and provider as needed)

## How to run one file at a time
1. `dotnet new console -n CSharpPractice && cd CSharpPractice`
2. Replace the generated `Program.cs` with the content of the exercise
   file you're working on.
3. `dotnet run`

## How to submit
Push this folder to your personal public GitHub repo and share the URL.

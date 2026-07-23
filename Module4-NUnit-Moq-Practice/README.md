# Module 4 – NUnit and Moq: Hands-On Practice

This package is aligned with **Module 4 (NUnit and Moq)** of the Digital Nurture 5.0
DotNet FSE Deep Skilling Handbook. It gives you starter source code plus test
files with `TODO` stubs so you can practice writing unit tests yourself.

## What's inside

```
DN-Module4-NUnit-Moq.sln
src/
  DN.Calculator/          -> Calculator, StringHelper, ArrayHelper (classes to test)
  DN.OrderService/        -> OrderProcessor + interfaces to mock (IInventoryRepository, IEmailService)
tests/
  DN.Calculator.Tests/    -> NUnit tests (strings, arrays/collections, return types,
                             void methods, exceptions, private/internal methods)
  DN.OrderService.Tests/  -> NUnit + Moq tests (constructor DI, mocking, state-based
                             vs interaction testing, verifying collaborators)
```

## Prerequisites

- Visual Studio Community (2022) or Visual Studio Code with the C# Dev Kit
- .NET 8 SDK

## How to use this

1. Open `DN-Module4-NUnit-Moq.sln` in Visual Studio (or the folder in VS Code).
2. Restore/build once to pull down the NuGet packages (NUnit, NUnit3TestAdapter,
   Microsoft.NET.Test.Sdk, Moq):
   ```
   dotnet restore
   dotnet build
   ```
3. Open the Test Explorer (or run `dotnet test`). You'll see failing tests —
   each one currently has `Assert.Fail("TODO: implement this test");`.
4. Work through each `TODO` in order:
   - `tests/DN.Calculator.Tests/CalculatorTests.cs`
   - `tests/DN.Calculator.Tests/StringHelperTests.cs`
   - `tests/DN.Calculator.Tests/ArrayHelperTests.cs`
   - `tests/DN.OrderService.Tests/OrderProcessorTests.cs`
5. Replace `Assert.Fail(...)` with real Arrange/Act/Assert code, then re-run
   `dotnet test` until everything passes.

## Topics covered (maps to the handbook's Core Unit Testing Techniques /
Breaking External Dependencies sections)

| Topic | File |
|---|---|
| Testing return type of methods | `CalculatorTests.cs` (Add) |
| Parameterized tests (`[TestCase]`) | `CalculatorTests.cs`, `StringHelperTests.cs` |
| Testing methods that throw exceptions | `CalculatorTests.cs` (Divide), `ArrayHelperTests.cs` (FindMax), `StringHelperTests.cs` (Reverse) |
| Testing void methods | `CalculatorTests.cs` (ClearHistory) |
| Testing private/internal methods | `CalculatorTests.cs` (FormatResult) |
| Testing strings | `StringHelperTests.cs` |
| Testing arrays and collections | `ArrayHelperTests.cs` |
| Ignoring tests | `StringHelperTests.cs` (`[Ignore]`) |
| Set Up and Tear Down | `CalculatorTests.cs` (`[SetUp]`/`[TearDown]`) |
| Dependency Injection via Constructor | `OrderProcessor.cs` |
| Creating Mock Objects Using Moq | `OrderProcessorTests.cs` |
| State-based testing | `OrderProcessorTests.cs` (Exercise 1) |
| Interaction testing / verifying collaborators | `OrderProcessorTests.cs` (Exercises 2–4) |

## Self-evaluation

Once your tests pass:
- Run `dotnet test` and confirm all tests are green.
- Check code coverage if you'd like (the `coverlet.collector` package is
  already referenced).
- Compare your assertions against the "Reference Notes" idea in each TODO
  comment — did you cover the happy path AND the edge cases (null, empty,
  zero, exception)?

Good luck — this mirrors what you'll be expected to demonstrate in the
Deep Skilling Final KBA Assessment for this skill.

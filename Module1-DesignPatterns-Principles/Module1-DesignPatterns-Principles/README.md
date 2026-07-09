# Module 1 – Design Patterns and Principles
### Digital Nurture 5.0 – Deep Skilling (DotNet FSE Angular)

This folder contains my hands-on practice for **Module 1** of the DN 5.0 Deep Skilling program,
covering the **SOLID Principles** and commonly used **Design Patterns** (Creational, Structural,
Behavioral, and Architectural).

Each topic includes a runnable C# console example with comments explaining the concept.

## 📁 Folder Structure

```
Module1-DesignPatterns-Principles/
│
├── 01-SOLID-Principles/
│   ├── 01-SingleResponsibility/      (BadExample.cs vs GoodExample.cs)
│   ├── 02-OpenClosed/                (BadExample.cs vs GoodExample.cs)
│   ├── 03-LiskovSubstitution/        (BadExample.cs vs GoodExample.cs)
│   ├── 04-InterfaceSegregation/      (BadExample.cs vs GoodExample.cs)
│   └── 05-DependencyInversion/       (BadExample.cs vs GoodExample.cs)
│
└── 02-DesignPatterns/
    ├── Creational/
    │   ├── Singleton/          → Logger.Instance (thread-safe lazy singleton)
    │   ├── FactoryMethod/      → ShapeFactory creates Circle/Square/Triangle
    │   └── Builder/            → HouseBuilder fluent construction
    │
    ├── Structural/
    │   ├── Adapter/            → LegacyXmlReportGenerator → IJsonReport
    │   ├── Decorator/          → PlainCoffee + Milk/Sugar decorators
    │   └── Proxy/              → ProxyImage lazy-loads RealImage
    │
    ├── Behavioral/
    │   ├── Observer/           → Stock notifies subscribed Investors
    │   ├── Strategy/           → ShoppingCart swaps payment strategies
    │   └── Command/            → RemoteControl with Undo support
    │
    └── Architectural/
        ├── MVC/                → Student Model-View-Controller demo
        └── DependencyInjection/→ OrderService with injected IDiscountService
```

## ✅ Topics Covered
- **SOLID Principles:** SRP, OCP, LSP, ISP, DIP — each with a "Bad" (violation) and "Good" (fixed) example
- **Creational Patterns:** Singleton, Factory Method, Builder
- **Structural Patterns:** Adapter, Decorator, Proxy
- **Behavioral Patterns:** Observer, Strategy, Command
- **Architectural Patterns:** MVC, Dependency Injection

## ▶️ How to Run Any Example
Each `.cs` file is self-contained with its own `Main` method. To run one individually:

```bash
# Example: running the Singleton pattern
mkdir temp-run && cd temp-run
dotnet new console
# Replace the generated Program.cs content with the file you want to run
dotnet run
```

Or open the whole folder in **Visual Studio** / **Visual Studio Code**, create a console
project, and copy the relevant file's content into `Program.cs` to test it.

## 📚 Reference
Learning links used (from the DN 5.0 Handbook):
- SOLID Principles: https://www.baeldung.com/solid-principles
- Design Patterns: https://medium.com/@softwaretechsolution/design-pattern-81ef65829de2

---
*Part of the Digital Nurture 5.0 Deep Skilling Program – DotNet FSE Angular track*

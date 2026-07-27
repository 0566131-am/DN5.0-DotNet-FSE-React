# Prompt Engineering Exercises

Try each prompt below with GitHub Copilot (inline suggestions or Copilot Chat, as noted),
then jot a one-line note on what worked or didn't.

## Zero-shot
1. `// Write a method that reverses a string without using built-in Reverse()`
2. `// Write a method that checks if a number is a power of two`
3. `// Write a method that removes duplicate items from a List<int>`

**Notes:**


## Few-shot
1.
```
// Example: Square(3) returns 9
// Example: Square(5) returns 25
// Write Cube(int n) following the same style
```
2.
```
// Example: FormatCurrency(1000) returns "$1,000.00"
// Example: FormatCurrency(50) returns "$50.00"
// Write FormatPercentage(double value) following the same style
```

**Notes:**


## Chain-of-thought (use Copilot Chat)
1. "Before writing the code, list the steps needed to validate a password (min length,
   uppercase, number, special character), then write the C# method."
2. "Before writing the code, explain what could go wrong when parsing a date from user
   input, then write a safe ParseDate method that handles those cases."

**Notes:**


## Best-practice prompts (clear instructions, context, output format)
1. "Write a C# extension method for `string` called `Truncate(int maxLength)` that
   shortens a string and appends '...' if it was cut off. Include XML doc comments."
2. "Generate 5 NUnit test cases for a `IsValidEmail(string email)` method, covering
   valid emails, missing @ symbol, missing domain, empty string, and null input."

**Notes:**

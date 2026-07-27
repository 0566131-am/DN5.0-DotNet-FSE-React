# Module 14 – Gen AI Fundamentals — Hands-on Practice

Covers: Generative AI fundamentals, prompt engineering techniques (zero-shot, few-shot,
chain-of-thought), and hands-on usage of GitHub Copilot including its security/ethical
considerations.

## What's included
`prompt-exercises.md` — a set of prompts to actually try, organized by technique, plus a
Copilot-specific hands-on checklist.

## Problem Statements

### 1. Setup
- Install the GitHub Copilot extension in VS Code.
- Sign in with your GitHub account (needs an active Copilot subscription/trial).
- Open any of your DN5.0 project folders (e.g., Module6/ProductCatalogAPI) so Copilot has
  real context to work with.

### 2. Zero-shot prompting
In a scratch `.cs` file, type only a comment describing what you want with no examples,
and see what Copilot suggests:
```csharp
// Write a method that returns true if a string is a palindrome
```
Note whether the first suggestion is usable as-is or needs edits.

### 3. Few-shot prompting
Give Copilot 1-2 examples first, then ask for a new one in the same style:
```csharp
// Example: IsEven(4) returns true
// Example: IsEven(7) returns false
// Write IsPrime(int n) following the same style
```
Compare the quality/consistency of the result against the zero-shot attempt.

### 4. Chain-of-thought prompting
Ask Copilot Chat (not just inline suggestions) to reason step by step before writing code:
```
Before writing the code, list the edge cases for validating an email address,
then write a C# method that handles all of them.
```
Note whether asking it to reason first changed the quality of the final code.

### 5. Generate tests and docs with Copilot
- Select a method in your ProductCatalogAPI project and ask Copilot Chat: "Generate NUnit
  tests for this method."
- Ask it to "add XML doc comments to this method."
- Review both outputs critically — don't accept blindly.

### 6. Refactor with Copilot
Pick a slightly messy method (or intentionally write one with a long if/else chain) and
ask Copilot Chat: "Refactor this method for readability without changing its behavior."

### 7. Security and ethical review
For everything Copilot generated above, answer honestly:
- Did you review every suggestion before accepting it, or did you Tab-accept blindly?
- Could any suggested code contain a security issue (e.g., missing input validation,
  hardcoded secrets)?
- Is there any licensing/attribution risk in code Copilot generated that closely
  resembles a known open-source snippet?

## Check your understanding
- https://www.mygreatlearning.com/blog/generative-ai-quiz/
- https://aitoolsnote.com/quiz-prompt-engineering-mcq/

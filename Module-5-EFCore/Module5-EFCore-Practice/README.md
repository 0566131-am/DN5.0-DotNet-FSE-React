# Module 5 – Entity Framework Core 8.0 (Practice)

Covers the DN 5.0 learning objectives: ORM/EF Core concepts, Code-First model creation,
CRUD operations, LINQ queries, and migrations.

## Files
- `Models/Student.cs`, `Models/Course.cs`, `Models/Enrollment.cs` — Code-First entities
  (Student ↔ Course many-to-many via Enrollment join entity)
- `Data/AppDbContext.cs` — DbContext, connection string, relationship config, seed data
- `Program.cs` — CRUD (AddAsync, Find, FirstOrDefault, ToListAsync, Update, Remove) +
  LINQ queries (Where, OrderBy, Select/projection to DTO)

## Problem Statements to Practice
1. Add a `Department` entity with a one-to-many relationship to `Course`.
2. Write a migration that adds a `PhoneNumber` column to `Student`.
3. Write a LINQ query that returns each course with its enrolled student count
   (hint: `GroupBy` + projection).
4. Implement `AsNoTracking()` on a read-only query and explain why it's faster.
5. Add exception handling around `SaveChangesAsync()` for a duplicate email insert.

## Setup
1. Update the connection string in `Data/AppDbContext.cs` (`Server=...`) to match your
   local SQL Server / SSMS instance name.
2. From inside this project folder:
   ```
   dotnet restore
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   dotnet run
   ```
   (If `dotnet ef` isn't recognized: `dotnet tool install --global dotnet-ef`)

## Pushing to GitHub — do this from a separate cloned repo folder, not from here

Your recurring issue has been running git commands **inside the module folder** itself.
Keep this folder as your working/practice copy, and instead:

```powershell
# 1) Clone your personal repo ONCE, somewhere separate, e.g. C:\Users\ASUS\repos
cd C:\Users\ASUS\repos
git clone https://github.com/0566131-am/<your-repo-name>.git
cd <your-repo-name>

# 2) Create/enter a Module-5 folder inside the CLONED repo, then copy the practice files in
mkdir Module-5-EFCore
Copy-Item -Recurse "C:\path\to\Module5-EFCore-Practice\*" ".\Module-5-EFCore\"

# 3) Stage, commit, push — all from inside the cloned repo folder
git add .
git commit -m "Add Module 5 - Entity Framework Core practice"
git push origin main
```

If you hit "unrelated histories" or a Vim merge-commit screen again, that means you're
mixing `git init` in the module folder with a separately cloned repo — stick to the
cloned repo folder only, and avoid running `git init` inside `Module5-EFCore-Practice`.

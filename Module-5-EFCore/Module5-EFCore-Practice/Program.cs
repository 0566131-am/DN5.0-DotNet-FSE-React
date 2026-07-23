using Microsoft.EntityFrameworkCore;
using Module5EFCorePractice.Data;
using Module5EFCorePractice.Models;

namespace Module5EFCorePractice
{
    // Module 5 - Entity Framework Core 8.0 practice
    // Covers: DbContext setup, Code-First model, migrations, CRUD (AddAsync, Find, FirstOrDefault,
    // ToListAsync, Update, Remove/DeleteRange), and LINQ queries (Where, Select, OrderBy, projection to DTOs).
    class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            // Ensures the database + schema exist. In real projects prefer migrations:
            //   dotnet ef migrations add InitialCreate
            //   dotnet ef database update
            await db.Database.EnsureCreatedAsync();

            Console.WriteLine("=== Module 5: Entity Framework Core 8.0 Practice ===\n");

            await CreateRecordsAsync(db);
            await ReadRecordsAsync(db);
            await UpdateRecordAsync(db);
            await LinqQueriesAsync(db);
            await DeleteRecordAsync(db);

            Console.WriteLine("\nDone. Press any key to exit.");
            Console.ReadKey();
        }

        // ---------- CREATE ----------
        static async Task CreateRecordsAsync(AppDbContext db)
        {
            Console.WriteLine("-- Create --");

            var newStudent = new Student
            {
                FullName = "Anjali Sharma",
                Email = "anjali@example.com",
                EnrollmentDate = DateTime.UtcNow
            };

            await db.Students.AddAsync(newStudent);
            await db.SaveChangesAsync();

            Console.WriteLine($"Inserted student: {newStudent.FullName} (Id={newStudent.StudentId})\n");
        }

        // ---------- READ ----------
        static async Task ReadRecordsAsync(AppDbContext db)
        {
            Console.WriteLine("-- Read --");

            // Find: fastest way to look up by primary key (checks local cache first)
            var studentById = await db.Students.FindAsync(1);
            Console.WriteLine($"Find(1): {studentById?.FullName}");

            // FirstOrDefault: query with a condition
            var studentByEmail = await db.Students
                .FirstOrDefaultAsync(s => s.Email == "ravi@example.com");
            Console.WriteLine($"FirstOrDefault by email: {studentByEmail?.FullName}");

            // ToListAsync: retrieve all rows
            var allStudents = await db.Students.ToListAsync();
            Console.WriteLine($"Total students: {allStudents.Count}\n");
        }

        // ---------- UPDATE ----------
        static async Task UpdateRecordAsync(AppDbContext db)
        {
            Console.WriteLine("-- Update --");

            var student = await db.Students.FirstOrDefaultAsync(s => s.FullName == "Ravi Kumar");
            if (student is not null)
            {
                student.Email = "ravi.kumar@example.com";
                // EF Core automatically tracks the change; SaveChangesAsync persists it.
                await db.SaveChangesAsync();
                Console.WriteLine($"Updated email for {student.FullName} -> {student.Email}\n");
            }
        }

        // ---------- LINQ QUERIES ----------
        static async Task LinqQueriesAsync(AppDbContext db)
        {
            Console.WriteLine("-- LINQ Queries --");

            // Where + OrderBy
            var recentStudents = await db.Students
                .Where(s => s.EnrollmentDate >= new DateTime(2026, 1, 1))
                .OrderByDescending(s => s.EnrollmentDate)
                .ToListAsync();

            Console.WriteLine($"Students enrolled since Jan 2026: {recentStudents.Count}");

            // Projection into a DTO (avoids pulling back the whole entity)
            var studentSummaries = await db.Students
                .Select(s => new StudentSummaryDto
                {
                    Name = s.FullName,
                    Email = s.Email
                })
                .ToListAsync();

            foreach (var summary in studentSummaries)
            {
                Console.WriteLine($"  {summary.Name} <{summary.Email}>");
            }

            Console.WriteLine();
        }

        // ---------- DELETE ----------
        static async Task DeleteRecordAsync(AppDbContext db)
        {
            Console.WriteLine("-- Delete --");

            var student = await db.Students.FirstOrDefaultAsync(s => s.FullName == "Anjali Sharma");
            if (student is not null)
            {
                db.Students.Remove(student);
                await db.SaveChangesAsync();
                Console.WriteLine($"Deleted student: {student.FullName}");
            }
        }
    }

    // Simple DTO used for the LINQ projection example above.
    public class StudentSummaryDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}

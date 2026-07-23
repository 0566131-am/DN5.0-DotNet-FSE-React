using Microsoft.EntityFrameworkCore;
using Module5EFCorePractice.Models;

namespace Module5EFCorePractice.Data
{
    // Code-First DbContext: EF Core will generate the database schema from these classes.
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Update the Server/Database values to match your local SQL Server / SSMS instance.
            // Trusted_Connection uses Windows Authentication (typical for local SSMS setups).
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=Module5PracticeDb;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the many-to-many relationship via the Enrollment join entity
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            // Seed a little starter data (used by "Update-Database" / "dotnet ef database update")
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FullName = "Mubeena Pathan", Email = "mubeena@example.com", EnrollmentDate = new DateTime(2026, 1, 10) },
                new Student { StudentId = 2, FullName = "Ravi Kumar", Email = "ravi@example.com", EnrollmentDate = new DateTime(2026, 1, 12) }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Title = "ASP.NET Core Web API", Credits = 4 },
                new Course { CourseId = 2, Title = "Entity Framework Core", Credits = 3 }
            );
        }
    }
}

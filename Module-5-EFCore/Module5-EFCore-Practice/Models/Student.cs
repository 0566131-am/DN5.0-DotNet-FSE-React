using System.ComponentModel.DataAnnotations;

namespace Module5EFCorePractice.Models
{
    // Simple entity representing a Student.
    // Demonstrates: Primary Key, required fields, one-to-many navigation property.
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

        // Navigation property: one Student can have many Enrollments (many-to-many with Course via Enrollment)
        public List<Enrollment> Enrollments { get; set; } = new();
    }
}

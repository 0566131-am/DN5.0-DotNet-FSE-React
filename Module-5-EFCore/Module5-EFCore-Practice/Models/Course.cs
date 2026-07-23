using System.ComponentModel.DataAnnotations;

namespace Module5EFCorePractice.Models
{
    // Simple entity representing a Course.
    // Demonstrates: Primary Key, required fields, one-to-many navigation property.
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; } = string.Empty;

        [Range(1, 10)]
        public int Credits { get; set; }

        // Navigation property: one Course can have many Enrollments (many-to-many with Student via Enrollment)
        public List<Enrollment> Enrollments { get; set; } = new();
    }
}

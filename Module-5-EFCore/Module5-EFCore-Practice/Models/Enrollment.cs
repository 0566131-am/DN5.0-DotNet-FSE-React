namespace Module5EFCorePractice.Models
{
    // Join entity for the many-to-many relationship between Student and Course.
    // Demonstrates: Foreign Keys, Navigation Properties, a many-to-many relationship with payload (Grade).
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        // Foreign key + navigation property to Student
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        // Foreign key + navigation property to Course
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public string? Grade { get; set; }
    }
}

// MVC (MODEL-VIEW-CONTROLLER) PATTERN
// Separates an application into three interconnected components:
// Model (data/business logic), View (presentation), Controller (input handling/coordination).
// This is a simplified console-based illustration of the pattern.
using System;

namespace Patterns.Architectural.MVC
{
    // ---------- MODEL ----------
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int RollNumber { get; set; }
        public double Cgpa { get; set; }
    }

    // ---------- VIEW ----------
    public class StudentView
    {
        public void DisplayStudentDetails(string name, int rollNumber, double cgpa)
        {
            Console.WriteLine("---- Student Record ----");
            Console.WriteLine($"Name       : {name}");
            Console.WriteLine($"Roll Number: {rollNumber}");
            Console.WriteLine($"CGPA       : {cgpa}");
            Console.WriteLine("-------------------------");
        }
    }

    // ---------- CONTROLLER ----------
    public class StudentController
    {
        private readonly Student _model;
        private readonly StudentView _view;

        public StudentController(Student model, StudentView view)
        {
            _model = model;
            _view = view;
        }

        public void SetStudentName(string name) => _model.Name = name;
        public void SetRollNumber(int rollNumber) => _model.RollNumber = rollNumber;
        public void SetCgpa(double cgpa) => _model.Cgpa = cgpa;

        public void UpdateView() =>
            _view.DisplayStudentDetails(_model.Name, _model.RollNumber, _model.Cgpa);
    }

    class Program
    {
        static void Main()
        {
            var model = new Student();
            var view = new StudentView();
            var controller = new StudentController(model, view);

            controller.SetStudentName("Ananya Reddy");
            controller.SetRollNumber(2105);
            controller.SetCgpa(8.7);

            controller.UpdateView();
        }
    }
}

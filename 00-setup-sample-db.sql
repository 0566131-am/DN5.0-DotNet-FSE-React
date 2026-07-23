/*
    00-setup-sample-db.sql
    Run this ONCE before attempting any Module 3 exercises.
    Creates SchoolDB with sample data used across all folders.
*/

IF DB_ID('SchoolDB') IS NOT NULL
BEGIN
    ALTER DATABASE SchoolDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SchoolDB;
END
GO

CREATE DATABASE SchoolDB;
GO

USE SchoolDB;
GO

CREATE TABLE Departments (
    DepartmentId INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName VARCHAR(100) NOT NULL,
    Budget DECIMAL(12,2) NOT NULL
);

CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100) NOT NULL,
    DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(DepartmentId),
    EnrollmentYear INT NOT NULL,
    GPA DECIMAL(3,2) NOT NULL,
    Email VARCHAR(150) NULL
);

CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName VARCHAR(100) NOT NULL,
    DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(DepartmentId),
    Credits INT NOT NULL
);

CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL FOREIGN KEY REFERENCES Students(StudentId),
    CourseId INT NOT NULL FOREIGN KEY REFERENCES Courses(CourseId),
    Grade DECIMAL(4,2) NULL,          -- out of 100, NULL = not yet graded
    EnrolledOn DATE NOT NULL DEFAULT GETDATE()
);

-- Table used later for trigger / audit exercises
CREATE TABLE StudentAudit (
    AuditId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL,
    Action VARCHAR(20) NOT NULL,
    ActionDate DATETIME NOT NULL DEFAULT GETDATE(),
    Details VARCHAR(500) NULL
);
GO

-- Seed data
INSERT INTO Departments (DepartmentName, Budget) VALUES
('Computer Science', 500000),
('Mathematics', 200000),
('Electronics', 350000);

INSERT INTO Students (FullName, DepartmentId, EnrollmentYear, GPA, Email) VALUES
('Aisha Khan', 1, 2022, 8.7, 'aisha@school.edu'),
('Ravi Kumar', 1, 2021, 7.9, 'ravi@school.edu'),
('Meera Reddy', 2, 2022, 9.1, 'meera@school.edu'),
('Sameer Ali', 3, 2023, 6.8, 'sameer@school.edu'),
('Divya Nair', 1, 2023, 8.3, 'divya@school.edu'),
('Karan Singh', 2, 2021, 7.2, 'karan@school.edu'),
('Priya Das', 3, 2022, 9.4, 'priya@school.edu'),
('Farhan Sheikh', 1, 2021, 6.5, 'farhan@school.edu');

INSERT INTO Courses (CourseName, DepartmentId, Credits) VALUES
('Data Structures', 1, 4),
('Operating Systems', 1, 4),
('Linear Algebra', 2, 3),
('Digital Circuits', 3, 3),
('Calculus II', 2, 3);

INSERT INTO Enrollments (StudentId, CourseId, Grade) VALUES
(1, 1, 88), (1, 2, 76), (2, 1, 65), (2, 2, 70),
(3, 3, 91), (3, 5, 85), (4, 4, 60), (5, 1, 82),
(5, 2, NULL), (6, 3, 74), (7, 4, 95), (8, 1, 55),
(8, 2, NULL);
GO

PRINT 'SchoolDB created and seeded successfully.';

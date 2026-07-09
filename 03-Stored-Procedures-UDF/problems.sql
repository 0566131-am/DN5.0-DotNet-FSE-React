/*
    03 - Stored Procedures and User-Defined Functions
    Uses SchoolDB (run 00-setup-sample-db.sql first)
*/
USE SchoolDB;
GO

-- Problem 1: Basic stored procedure
-- Create a procedure "usp_GetStudentsByDepartment" that takes a
-- @DepartmentId INT parameter and returns all students in that
-- department, ordered by GPA descending.


-- Problem 2: Procedure with output parameter
-- Create "usp_GetDepartmentAverageGPA" that takes @DepartmentId INT
-- and returns the average GPA via an OUTPUT parameter @AvgGPA DECIMAL(4,2).


-- Problem 3: Procedure with default parameter + optional filter
-- Create "usp_ListEnrollments" with an optional @MinGrade DECIMAL(4,2) = NULL
-- parameter. If @MinGrade is NULL, return all enrollments; otherwise
-- only return enrollments with Grade >= @MinGrade.


-- Problem 4: Modify a stored procedure
-- ALTER usp_GetStudentsByDepartment (Problem 1) to also accept an
-- optional @MinGPA DECIMAL(3,2) = 0 parameter that filters results.


-- Problem 5: Execute and grant permissions
-- Write the EXEC statement to call usp_GetStudentsByDepartment for
-- DepartmentId = 1. Then write a GRANT EXECUTE statement giving a
-- (hypothetical) user "ReportingUser" permission to run it.


-- Problem 6: Scalar-valued function
-- Create a scalar UDF "ufn_LetterGrade(@Grade DECIMAL(4,2))" that
-- returns 'A' for >=90, 'B' for >=80, 'C' for >=70, 'D' for >=60,
-- else 'F'.


-- Problem 7: Use the scalar function
-- Query all Enrollments showing StudentId, CourseId, Grade, and the
-- letter grade using ufn_LetterGrade.


-- Problem 8: Table-valued function (inline)
-- Create an inline table-valued function "ufn_StudentsAboveGPA(@MinGPA DECIMAL(3,2))"
-- that returns StudentId, FullName, GPA for students at/above @MinGPA.


-- Problem 9: Table-valued function (multi-statement)
-- Create a multi-statement TVF "ufn_DepartmentReportCard(@DepartmentId INT)"
-- that returns a table with columns (CourseName, AvgGrade, StudentCount)
-- for the given department, built up using intermediate logic
-- (e.g. a table variable populated in steps).


-- Problem 10: Drop and clean up
-- Write DROP statements for every procedure and function created above.

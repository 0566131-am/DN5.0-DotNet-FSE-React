/*
    01 - Window Functions & CTEs
    Uses SchoolDB (run 00-setup-sample-db.sql first)
*/
USE SchoolDB;
GO

-- Problem 1: ROW_NUMBER()
-- List all students with a row number ordered by GPA descending.
-- Write your query below:


-- Problem 2: RANK() vs DENSE_RANK()
-- Rank students within their department by GPA (highest = rank 1).
-- Show StudentId, FullName, DepartmentId, GPA, RANK, and DENSE_RANK
-- side by side so you can compare how they handle ties.
-- (Hint: use PARTITION BY DepartmentId)


-- Problem 3: OVER() with aggregate functions
-- For every enrollment row, show the student's grade alongside the
-- average grade of their department, without using GROUP BY.


-- Problem 4: Common Table Expression (CTE)
-- Write a CTE that computes each department's average GPA, then use it
-- in a main query to list only departments whose average GPA > 8.0.


-- Problem 5: Recursive CTE
-- Create a small "OrgChart" style recursive CTE. Reuse Students table:
-- pretend EnrollmentYear determines "seniority level" (2021 = level 1,
-- 2022 = level 2, 2023 = level 3). Build a recursive CTE that outputs
-- students level by level, starting from the earliest year.
-- (This is a stretch exercise: think about how recursion works even
-- without a natural parent-child column ready-made.)


-- Problem 6: GROUPING SETS
-- Produce a report showing total credits taken (SUM of Courses.Credits
-- via Enrollments) grouped by:
--   (DepartmentId, EnrollmentYear), (DepartmentId), () [grand total]
-- all in a single query using GROUPING SETS.


-- Problem 7: ROLLUP
-- Rewrite Problem 6 using ROLLUP instead of GROUPING SETS and compare
-- the result set differences.


-- Problem 8: PIVOT
-- Pivot the Enrollments table so each row is a StudentId and each
-- column is a CourseId, showing the Grade in each cell.


-- Problem 9: UNPIVOT
-- Take the pivoted result from Problem 8 and unpivot it back into
-- (StudentId, CourseId, Grade) rows. Confirm row counts match the
-- original (excluding NULLs, which UNPIVOT drops by default).


-- Problem 10: MERGE
-- You receive a "new semester grades" batch (see @NewGrades below).
-- Use MERGE to update existing Enrollments rows where a match exists
-- (StudentId + CourseId) and insert new rows where no match exists.

DECLARE @NewGrades TABLE (StudentId INT, CourseId INT, Grade DECIMAL(4,2));
INSERT INTO @NewGrades VALUES
(1, 2, 80),   -- existing enrollment, should UPDATE grade
(4, 1, 72);   -- new enrollment, should INSERT

-- Write your MERGE statement below:

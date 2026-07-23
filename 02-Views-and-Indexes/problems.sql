/*
    02 - Views and Indexes
    Uses SchoolDB (run 00-setup-sample-db.sql first)
*/
USE SchoolDB;
GO

-- Problem 1: Create a view
-- Create a view "vw_StudentSummary" showing StudentId, FullName,
-- DepartmentName, GPA, and EnrollmentYear (join Students + Departments).


-- Problem 2: Query and modify through a view
-- Query vw_StudentSummary for students with GPA > 8.
-- Then try updating a student's GPA through the view (UPDATE ... via
-- the view name). Note what happens/what's allowed on a multi-table view.


-- Problem 3: ALTER VIEW
-- Modify vw_StudentSummary to also include the student's Email.


-- Problem 4: Indexed view
-- Create a new view "vw_DeptStudentCount" (WITH SCHEMABINDING) that
-- shows DepartmentId and COUNT_BIG(*) of students per department.
-- Then create a unique clustered index on it to make it a materialized
-- indexed view.


-- Problem 5: Non-clustered index
-- Create a non-clustered index on Students(DepartmentId, GPA) and
-- explain (in a comment) which queries from folder 01 would benefit
-- from it.


-- Problem 6: Covering index
-- Design a covering index for this query:
--   SELECT StudentId, FullName, GPA FROM Students WHERE DepartmentId = 1;
-- (Hint: think about key columns vs INCLUDE columns.)


-- Problem 7: Drop and recreate
-- Drop the index you created in Problem 5, then recreate it with
-- FILLFACTOR = 80.


-- Problem 8: Index fragmentation check
-- Write a query against sys.dm_db_index_physical_stats to check the
-- fragmentation percentage of indexes on the Students table.


-- Problem 9: Query optimization
-- Take this slow-ish query and rewrite it to use an index-friendly
-- predicate (avoid function-wrapped columns in WHERE):
--   SELECT * FROM Students WHERE YEAR(GETDATE()) - EnrollmentYear >= 2;
-- Rewrite so the WHERE clause doesn't wrap a computed expression around
-- a column unnecessarily.


-- Problem 10: Drop view
-- Clean up: write the DROP VIEW statements for both views created above.

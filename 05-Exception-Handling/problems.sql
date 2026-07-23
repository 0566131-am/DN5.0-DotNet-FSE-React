/*
    05 - Exception Handling
    Uses SchoolDB (run 00-setup-sample-db.sql first)
*/
USE SchoolDB;
GO

-- Problem 1: Basic TRY/CATCH
-- Write a TRY/CATCH block that attempts to insert a Student row with
-- a DepartmentId that doesn't exist (e.g. 999), and in the CATCH block
-- prints the error message using ERROR_MESSAGE().


-- Problem 2: Capture full error details
-- Extend Problem 1's CATCH block to also print ERROR_NUMBER(),
-- ERROR_SEVERITY(), ERROR_STATE(), ERROR_LINE(), and ERROR_PROCEDURE().


-- Problem 3: Divide-by-zero handling
-- Write a TRY/CATCH block that divides a student's GPA by
-- (EnrollmentYear - EnrollmentYear) to force a divide-by-zero error,
-- and handle it gracefully with a custom message.


-- Problem 4: Nested TRY/CATCH
-- Write an outer TRY/CATCH that calls an operation which itself has an
-- inner TRY/CATCH. In the inner CATCH, deliberately re-throw the error
-- (using THROW with no parameters) so the outer CATCH also handles it.
-- Print a distinguishing message in each CATCH block so you can see
-- both fire.


-- Problem 5: THROW with custom error
-- Write a stored procedure "usp_EnrollStudent" that checks if a
-- @StudentId exists; if not, use THROW to raise a custom error
-- (e.g. 50001, 'Student does not exist', 1).


-- Problem 6: RAISERROR
-- Rewrite Problem 5 using RAISERROR instead of THROW. Compare the two
-- in a comment: what's different about severity levels, backwards
-- compatibility, and formatting placeholders (%s, %d)?


-- Problem 7: RAISERROR with severity levels
-- Write three RAISERROR calls demonstrating severity 10 (informational),
-- 16 (typical user error), and explain (in a comment, don't actually
-- run) what would happen at severity >= 20.


-- Problem 8: TRY/CATCH inside a transaction
-- Write a TRY block that starts a transaction, performs two inserts
-- into Enrollments, and commits. In the CATCH block, check
-- XACT_STATE() and ROLLBACK if the transaction is still active.
-- (This bridges into Module 06 - Transactions.)


-- Problem 9: Custom error message with sp_addmessage (optional/advanced)
-- Research and write (as a comment, since it needs sysadmin rights)
-- how you would register a reusable custom error message with
-- sp_addmessage, then RAISERROR it by message number.


-- Problem 10: Logging errors to a table
-- Create a table "ErrorLog" (ErrorId, ErrorMessage, ErrorNumber,
-- ErrorDate). Write a TRY/CATCH block that logs any caught error into
-- this table instead of just printing it.

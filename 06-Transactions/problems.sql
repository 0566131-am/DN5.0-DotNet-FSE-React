/*
    06 - Transactions
    Uses SchoolDB (run 00-setup-sample-db.sql first)
*/
USE SchoolDB;
GO

-- Problem 1: Basic explicit transaction
-- Write a BEGIN TRANSACTION / COMMIT block that inserts a new
-- Department and a new Student in that department as a single atomic
-- unit.


-- Problem 2: ROLLBACK on failure
-- Repeat Problem 1, but this time insert a Student with an invalid
-- DepartmentId (to force a foreign key error) inside the transaction.
-- Wrap it in TRY/CATCH and ROLLBACK in the CATCH block so the
-- Department insert doesn't persist either.


-- Problem 3: Savepoints
-- Start a transaction, insert a Department, create a SAVE TRANSACTION
-- named "AfterDept", then insert a Student. If the Student insert
-- fails, ROLLBACK TRANSACTION AfterDept (not the whole transaction) so
-- the Department insert still commits.


-- Problem 4: Implicit vs explicit transactions
-- In a comment, explain the difference between SET IMPLICIT_TRANSACTIONS ON
-- and explicitly using BEGIN TRANSACTION/COMMIT. Which is the SQL
-- Server default?


-- Problem 5: Nested transactions
-- Write a stored procedure "usp_Outer" that calls another procedure
-- "usp_Inner", where both use BEGIN TRAN/COMMIT TRAN. Add a comment
-- explaining why @@TRANCOUNT matters here and how a ROLLBACK inside
-- the inner procedure affects the outer one.


-- Problem 6: Transaction isolation levels
-- Write the SET TRANSACTION ISOLATION LEVEL statements for all four
-- standard levels (READ UNCOMMITTED, READ COMMITTED, REPEATABLE READ,
-- SERIALIZABLE) and add a one-line comment under each describing what
-- anomaly it prevents (dirty read / non-repeatable read / phantom read).


-- Problem 7: Dirty read demonstration (conceptual)
-- Describe (in comments, as pseudocode across "Session A" / "Session B")
-- a scenario showing a dirty read under READ UNCOMMITTED, and how
-- READ COMMITTED would prevent it.


-- Problem 8: Locking and blocking
-- Write a query against sys.dm_tran_locks to see current locks held
-- in the SchoolDB database.


-- Problem 9: Detecting deadlocks
-- In a comment, describe two ways SQL Server helps detect/handle
-- deadlocks (e.g. deadlock victim selection, Trace Flag 1222 /
-- Extended Events).


-- Problem 10: ACID in practice
-- Write one transaction example touching Students and Enrollments
-- that demonstrates all four ACID properties in your own words
-- (as comments above each relevant statement): Atomicity, Consistency,
-- Isolation, Durability.

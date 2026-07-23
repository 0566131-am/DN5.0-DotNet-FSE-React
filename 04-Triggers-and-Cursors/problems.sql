/*
    04 - Triggers and Cursors
    Uses SchoolDB (run 00-setup-sample-db.sql first)
*/
USE SchoolDB;
GO

-- Problem 1: AFTER INSERT trigger
-- Create a trigger "trg_Students_AfterInsert" on Students that inserts
-- a row into StudentAudit (Action = 'INSERT') for every new student,
-- capturing StudentId and a Details message with the FullName.


-- Problem 2: AFTER UPDATE trigger
-- Create "trg_Students_AfterUpdate" that logs to StudentAudit whenever
-- a student's GPA changes, recording old and new GPA in Details.
-- (Hint: use the inserted and deleted pseudo-tables.)


-- Problem 3: AFTER DELETE trigger
-- Create "trg_Students_AfterDelete" that logs deletions to StudentAudit
-- with Action = 'DELETE'.


-- Problem 4: Test your triggers
-- Write INSERT, UPDATE, and DELETE statements against Students to
-- verify all three triggers fire correctly, then SELECT * FROM
-- StudentAudit to confirm.


-- Problem 5: INSTEAD OF trigger
-- Create the view "vw_ActiveStudents" (GPA > 7) then create an
-- INSTEAD OF INSERT trigger on it that only allows inserts where the
-- new row's GPA > 7, silently doing nothing (or raising an error) if
-- not.


-- Problem 6: Disable / enable a trigger
-- Write the statements to disable trg_Students_AfterInsert, then
-- re-enable it.


-- Problem 7: Basic cursor
-- Write a cursor that loops through all Departments and PRINTs
-- "<DepartmentName> has budget <Budget>" for each row.


-- Problem 8: Cursor with conditional logic
-- Write a cursor over Students that PRINTs a warning message for any
-- student with GPA < 7.0, and a congratulations message for GPA >= 9.0
-- (skip everyone in between).


-- Problem 9: Cursor vs set-based alternative
-- Rewrite Problem 8 as a single set-based query (no cursor) using CASE.
-- Add a comment explaining why the set-based version is usually
-- preferred in SQL Server.


-- Problem 10: Cursor cleanup
-- For any cursor you declared above, make sure you always end with
-- CLOSE and DEALLOCATE. Write a short comment listing the 4 lifecycle
-- steps of a cursor (DECLARE, OPEN, FETCH, CLOSE/DEALLOCATE).

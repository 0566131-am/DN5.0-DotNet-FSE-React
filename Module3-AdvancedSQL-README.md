# Module 3 – Advanced SQL Using SQL Server

Practice exercises for the DN 5.0 Deep Skilling handbook, Module 3.
Covers: Window Functions & CTEs, Views & Indexes, Stored Procedures & UDFs,
Triggers & Cursors, Exception Handling, and Transactions.

## How to use this folder

1. Open SQL Server Management Studio (SSMS).
2. Run `00-setup-sample-db.sql` first — it creates a small sample database
   (`SchoolDB`) with `Students`, `Courses`, `Enrollments`, and `Departments`
   tables plus seed data. All exercises below use this schema.
3. Go folder by folder (01 → 06). Each folder has a `problems.sql` file with
   commented problem statements — write your solution directly below each
   problem comment.
4. There are no answer keys included on purpose — solve them yourself first,
   then compare with the handbook's self-learning reference links if stuck.

## Folder map

| Folder | Topic | Handbook reference |
|---|---|---|
| 01-Window-Functions-CTE | OVER(), PARTITION BY, ROW_NUMBER, RANK, DENSE_RANK, GROUPING SETS, CUBE, ROLLUP, CTE, Recursive CTE, MERGE, PIVOT/UNPIVOT | Advanced Concepts |
| 02-Views-and-Indexes | Views, Indexed views, Index types, fragmentation, query optimization | Views and Indexes |
| 03-Stored-Procedures-UDF | Stored procedures, parameters, scalar/table-valued functions | Stored Procedures and User-Defined Functions |
| 04-Triggers-and-Cursors | AFTER/INSTEAD OF/Logon triggers, cursor lifecycle | Triggers and Cursors |
| 05-Exception-Handling | TRY/CATCH, nested TRY/CATCH, THROW, RAISERROR | Exception Handling |
| 06-Transactions | ACID, BEGIN/COMMIT/ROLLBACK, savepoints, isolation levels, deadlocks | Transactions |

Good luck — same approach as your DSA sheet: solve, self-check, then move on.

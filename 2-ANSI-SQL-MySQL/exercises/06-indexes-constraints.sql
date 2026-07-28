USE dn5_practice;

-- TODO 1: Create an index on students(last_name) to speed up lookups
-- by last name.


-- TODO 2: Create a composite index on enrollments(student_id, course_id).


-- TODO 3: Add a UNIQUE constraint on courses(course_name) so no two
-- courses can have the same name (use ALTER TABLE ... ADD CONSTRAINT).


-- TODO 4: Add a CHECK constraint on students so that gpa must be
-- between 0 and 10 (MySQL 8.0.16+ enforces CHECK constraints).


-- TODO 5: Show all indexes on the students table
-- (SHOW INDEX FROM students;).


-- TODO 6: Drop the index you created in TODO 1.

USE dn5_practice;

-- TODO 1: INNER JOIN students with departments to show each student's
-- name alongside their department name.


-- TODO 2: INNER JOIN students, enrollments, and courses to list which
-- courses each student is enrolled in, with their grade.


-- TODO 3: LEFT JOIN students with enrollments to find students who
-- have NOT enrolled in any course (look for NULL enrollment_id).


-- TODO 4: RIGHT JOIN courses with enrollments to list every course
-- even if it has zero enrollments.


-- TODO 5: Self-join students to find pairs of students in the SAME
-- department (excluding pairing a student with themself).


-- TODO 6: Subquery in WHERE - find students whose gpa is above the
-- overall average gpa (use a subquery: (SELECT AVG(gpa) FROM students)).


-- TODO 7: Subquery in FROM - find the max enrollment count per student
-- using a derived table.


-- TODO 8: Correlated subquery - for each department, find students
-- whose gpa is above THAT department's average gpa.

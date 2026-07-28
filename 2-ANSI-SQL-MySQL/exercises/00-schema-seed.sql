-- Run this first to set up the practice schema and sample data.

CREATE DATABASE IF NOT EXISTS dn5_practice;
USE dn5_practice;

DROP TABLE IF EXISTS enrollments;
DROP TABLE IF EXISTS students;
DROP TABLE IF EXISTS courses;
DROP TABLE IF EXISTS departments;

CREATE TABLE departments (
  dept_id INT PRIMARY KEY AUTO_INCREMENT,
  dept_name VARCHAR(50) NOT NULL
);

CREATE TABLE students (
  student_id INT PRIMARY KEY AUTO_INCREMENT,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  email VARCHAR(100) UNIQUE,
  dept_id INT,
  gpa DECIMAL(3,2),
  joined_on DATE,
  FOREIGN KEY (dept_id) REFERENCES departments(dept_id)
);

CREATE TABLE courses (
  course_id INT PRIMARY KEY AUTO_INCREMENT,
  course_name VARCHAR(100) NOT NULL,
  credits INT NOT NULL,
  dept_id INT,
  FOREIGN KEY (dept_id) REFERENCES departments(dept_id)
);

CREATE TABLE enrollments (
  enrollment_id INT PRIMARY KEY AUTO_INCREMENT,
  student_id INT,
  course_id INT,
  grade CHAR(2),
  enrolled_on DATE,
  FOREIGN KEY (student_id) REFERENCES students(student_id),
  FOREIGN KEY (course_id) REFERENCES courses(course_id)
);

INSERT INTO departments (dept_name) VALUES
  ('Computer Science'), ('Electronics'), ('Mechanical'), ('Civil');

INSERT INTO students (first_name, last_name, email, dept_id, gpa, joined_on) VALUES
  ('Asha', 'Rao', 'asha.rao@example.com', 1, 8.7, '2023-08-01'),
  ('Ravi', 'Kumar', 'ravi.kumar@example.com', 1, 6.9, '2023-08-01'),
  ('Meera', 'Iyer', 'meera.iyer@example.com', 2, 9.1, '2023-08-05'),
  ('Kiran', 'Shah', 'kiran.shah@example.com', 3, 5.8, '2023-08-10'),
  ('Divya', 'Nair', 'divya.nair@example.com', 1, 8.2, '2023-08-12'),
  ('Suresh', 'Patel', 'suresh.patel@example.com', 4, 7.4, '2023-08-15'),
  ('Priya', 'Menon', NULL, 2, 7.0, '2023-08-20');

INSERT INTO courses (course_name, credits, dept_id) VALUES
  ('Data Structures', 4, 1),
  ('Database Systems', 4, 1),
  ('Digital Circuits', 3, 2),
  ('Thermodynamics', 3, 3),
  ('Structural Analysis', 4, 4),
  ('Operating Systems', 4, 1);

INSERT INTO enrollments (student_id, course_id, grade, enrolled_on) VALUES
  (1, 1, 'A', '2023-09-01'),
  (1, 2, 'B', '2023-09-01'),
  (2, 1, 'C', '2023-09-01'),
  (3, 3, 'A', '2023-09-02'),
  (4, 4, 'D', '2023-09-03'),
  (5, 2, 'A', '2023-09-01'),
  (5, 6, 'B', '2023-09-05'),
  (6, 5, 'C', '2023-09-04'),
  (2, 6, 'B', '2023-09-05');

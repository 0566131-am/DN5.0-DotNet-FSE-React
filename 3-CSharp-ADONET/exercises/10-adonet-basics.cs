// Exercise 10: ADO.NET Fundamentals
// Concepts: Connection, Command, DataReader, DataAdapter, DataSet,
// DataTable - connected vs disconnected architecture
//
// This uses the 'dn5_practice' schema from Module 2 (ANSI SQL using
// MySQL). Install the MySql.Data or MySqlConnector NuGet package:
//   dotnet add package MySqlConnector
// (or swap the connection/command types for System.Data.SqlClient if
// you're using SQL Server instead - the ADO.NET pattern is identical.)

using System;
using System.Data;
using MySqlConnector; // dotnet add package MySqlConnector

class Program
{
    // TODO 0: Update this connection string for your own MySQL instance.
    static string connectionString =
        "Server=localhost;Database=dn5_practice;User=root;Password=yourpassword;";

    static void Main()
    {
        // TODO 1: CONNECTED ARCHITECTURE - open a MySqlConnection, create
        // a MySqlCommand with "SELECT student_id, first_name, last_name, gpa FROM students",
        // and use MySqlDataReader to loop through rows and print each
        // student. Remember to close/dispose the connection (use 'using').


        // TODO 2: Parameterized query - write a method that takes a
        // department id and returns matching students, using a
        // MySqlCommand with a parameter (@deptId) to avoid SQL injection.
        // NEVER build the SQL string via concatenation with user input.


        // TODO 3: INSERT via ADO.NET - write a method AddStudent(...)
        // that executes an INSERT command with parameters and returns
        // the number of affected rows (ExecuteNonQuery).


        // TODO 4: UPDATE and DELETE - write methods that update a
        // student's gpa and delete a student by id, both using
        // parameterized ExecuteNonQuery calls.


        // TODO 5: DISCONNECTED ARCHITECTURE - use a MySqlDataAdapter to
        // fill a DataTable (or DataSet) with the students table, then
        // loop through the DataTable's Rows WITHOUT keeping the
        // connection open (this is the key difference from TODO 1).


        // TODO 6: Add a short comment explaining, in your own words, the
        // difference between the "connected" (DataReader) and
        // "disconnected" (DataAdapter/DataSet) architectures, and when
        // you'd pick one over the other.
    }
}

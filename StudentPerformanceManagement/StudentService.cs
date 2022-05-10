using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class StudentService
    {
        public void Add(Student s)
        {

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@rollno", s.rollNo));
                command.Parameters.Add(new SqlParameter("@name", s.name));
                command.Parameters.Add(new SqlParameter("@email", s.email));
                command.Parameters.Add(new SqlParameter("@address", s.address));
                command.Parameters.Add(new SqlParameter("@courseCode", s.courseCode));
                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Student Added");
            }

        }
        public void Edit(Student s)
        {

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("editStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@studentId", s.studentId));
                command.Parameters.Add(new SqlParameter("@rollno", s.rollNo));
                command.Parameters.Add(new SqlParameter("@name", s.name));
                command.Parameters.Add(new SqlParameter("@email", s.email));
                command.Parameters.Add(new SqlParameter("@address", s.address));

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Student Edited");
            }

        }
        public void Delete(Student s)
        {
            Console.WriteLine("Enter Student ID = ");
            s.studentId = int.Parse(Console.ReadLine());

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("deleteStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@studentId", s.studentId));

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Student deleted successfully...!");
            }
        }
        public void DisplayStudentReport()
        {
            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DisplayStudentReport", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

                    }
                }
            }
        }

    }
}

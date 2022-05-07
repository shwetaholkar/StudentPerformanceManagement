using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class MarksService
    {
        public void Add()
        {
            Console.WriteLine("Enter StudentId = ");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SubjectId = ");
            int subjectId =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Marks = ");
            int marks = int.Parse(Console.ReadLine());
            
            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertMarks", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@studentId", studentId));
                command.Parameters.Add(new SqlParameter("@subjectId", subjectId));
                command.Parameters.Add(new SqlParameter("@marks", marks));
               
                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " row inserted");
            }

        }
    }
}

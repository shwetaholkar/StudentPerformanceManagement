using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class SubjectService
    {

        public void Add(Subject s)
        {

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertSubject", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@code", s.subjectCode));
                command.Parameters.Add(new SqlParameter("@title", s.title));
                command.Parameters.Add(new SqlParameter("@description", s.desc));
                command.Parameters.Add(new SqlParameter("@courseCode", s.courseCode));

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Subject Added...!");
            }
        }
        public void Edit(Subject s)
        {
            
            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("editSubject", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@subjectId", s.subjectId));
                command.Parameters.Add(new SqlParameter("@code", s.subjectCode));
                command.Parameters.Add(new SqlParameter("@title", s.title));
                command.Parameters.Add(new SqlParameter("@description", s.desc));
              
                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Student Edited");
            }
        }
        public void Delete(Subject s)
        {
            Console.WriteLine("Enter Subject ID = ");
            s.subjectId = int.Parse(Console.ReadLine());

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("deleteSubject", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@subjectId", s.subjectId));

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Subject deleted successfully...!");
            }
        }

    }
}
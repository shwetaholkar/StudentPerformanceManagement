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
        public void Add()
        {
            Console.WriteLine("Enter Subject Code = ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Title = ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter Subject Description = ");
            var desc = Console.ReadLine();
            Console.WriteLine("Enter Course ID = ");
            int courseId = int.Parse(Console.ReadLine());

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertSubject", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@code", code));
                command.Parameters.Add(new SqlParameter("@title", title));
                command.Parameters.Add(new SqlParameter("@description", desc));
                command.Parameters.Add(new SqlParameter("@courseId", courseId));

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " row inserted");
            }

        }
    }
}

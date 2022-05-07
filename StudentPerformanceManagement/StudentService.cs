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
        public void Add()
        {
            Console.WriteLine("Enter roll no = ");
            int rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name = ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Student E-mail = ");
            var email = Console.ReadLine();
            Console.WriteLine("Enter Student Address = ");
            var addr = Console.ReadLine();
            Console.WriteLine(" Enter Student Course ID = ");
            int courseId=int.Parse(Console.ReadLine());

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@rollno", rollNo));
                command.Parameters.Add(new SqlParameter("@name", name));
                command.Parameters.Add(new SqlParameter("@email", email));
                command.Parameters.Add(new SqlParameter("@address", addr));
                command.Parameters.Add(new SqlParameter("@courseId", courseId));
                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " row inserted");
            }

        }

    }
}

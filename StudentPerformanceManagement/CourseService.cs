using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class CourseService
    {
        public void Add()
        {
            Console.WriteLine("Enter Course Code = ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Course Title = ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter Course Description = ");
            var desc = Console.ReadLine();


            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertCourse", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@code",code));
                command.Parameters.Add(new SqlParameter("@title", title));
                command.Parameters.Add(new SqlParameter("@description", desc));
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

                //    }
                //}

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " row inserted");
            }

        }
    }
}


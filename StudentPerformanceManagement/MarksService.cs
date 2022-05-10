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
        public void Add(Marks m)
        {
            
            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insertMarks", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@rollNo", m.studRollNo));
                command.Parameters.Add(new SqlParameter("@subjectCode", m.subCode));
                command.Parameters.Add(new SqlParameter("@marks", m.marks));
               
                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " marks inserted");
            }

        }
        public void Delete(Marks m)
        {
            Console.WriteLine("Enter Marks ID = ");
            m.marksId = int.Parse(Console.ReadLine());

            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("deleteMarks", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@marksId", m.marksId));

                int rowsffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsffected + " Marks deleted successfully...!");
            }
        }
        public void DisplayMarksByRollno()
        {
            string connectionString = @"Data Source=DESKTOP-ERGIE03\MSSQLSERVER01;Initial Catalog=StudentPerformanceManagement;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DisplayMarksByRollNo", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());

                    }
                }
            }
        }
    }
}


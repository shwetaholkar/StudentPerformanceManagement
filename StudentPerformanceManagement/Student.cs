using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class Student
    {
        public int studentId;
        public int rollNo;
        public string name;
        public string email;
        public string address;
        public int courseId;
        public int courseCode;

        public void LoadDataForStudent()
        {
            Console.WriteLine("Enter roll no = ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name = ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student E-mail = ");
            email = Console.ReadLine();
            Console.WriteLine("Enter Student Address = ");
            address = Console.ReadLine();
            Console.WriteLine(" Enter Student Course code = ");
            courseCode = int.Parse(Console.ReadLine());
        }

        public void EditStudentData()
        {
            Console.WriteLine("Enter Student Id = ");
            studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter roll no = ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name = ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student E-mail = ");
            email = Console.ReadLine();
            Console.WriteLine("Enter Student Address = ");
            address = Console.ReadLine();
        }

        //public Student(int studentId, int rollNo, string name, string email, string address, int courseId)
        //{
        //    this.studentId = studentId;
        //    this.rollNo = rollNo;
        //    this.name = name;
        //    this.email = email;
        //    this.address = address;
        //    this.courseId = courseId;
        //}
    }
}

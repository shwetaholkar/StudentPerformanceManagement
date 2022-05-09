using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class Course
    {
        public int courseId;
        public int courseCode;
        public string title;
        public string description;

        public void LoadData()
        {
            Console.WriteLine("Enter Course Code = ");
            courseCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course Title = ");
            title = Console.ReadLine();

            Console.WriteLine("Enter Course Description = ");
            description = Console.ReadLine();

        }

        public void EditCourseData()
        {
            Console.WriteLine("Enter Course ID = ");
            courseId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course Code = ");
            courseCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course Title = ");
            title = Console.ReadLine();

            Console.WriteLine("Enter Course Description = ");
            description = Console.ReadLine();
        }

        //public Course(int courseId, int courseCode, string title, string description)
        //{
        //    this.courseId = courseId;
        //    this.courseCode = courseCode;
        //    this.title = title;
        //    this.description = description;
        //}


    }
}




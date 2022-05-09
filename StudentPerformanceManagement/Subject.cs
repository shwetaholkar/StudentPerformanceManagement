using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class Subject
    {
        public int subjectId;
        public int subjectCode;
        public string title;
        public string desc;
        public int courseId;
        public int courseCode;

        public void LoadDateForSubject()
        {
            Console.WriteLine("Enter Subject Code = ");
            subjectCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Title = ");
            title = Console.ReadLine();
            Console.WriteLine("Enter Subject Description = ");
            desc = Console.ReadLine();
            Console.WriteLine(" Enter Student Course code = ");
            courseCode = int.Parse(Console.ReadLine());
        }

        public void EditSubjectData()
        {
            Console.WriteLine("Enter Subject Id = ");
            subjectId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Code = ");
            subjectCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Title = ");
            title = Console.ReadLine();
            Console.WriteLine("Enter Subject Description = ");
            desc = Console.ReadLine();
            
        }

        //public Subject(int subjectId, int subjectCode, string title, string desc, int courseId)
        //{
        //    this.subjectId = subjectId;
        //    this.subjectCode = subjectCode;
        //    this.title = title;
        //    this.desc = desc;
        //    this.courseId = courseId;
        //}
    }
}

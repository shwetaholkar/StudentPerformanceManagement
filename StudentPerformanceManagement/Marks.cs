using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class Marks
    {
        public int marksId;
        public int studentId;
        public int subjectId;
        public int marks;
        public int studRollNo;
        public int subCode;

        public void LoadDataForMarks()
        {
            Console.WriteLine("Enter Student Rollno = ");
            studRollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Code = ");
            subCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Marks = ");
            marks = int.Parse(Console.ReadLine());
        }

        //public Marks(int marksId, int studentId, int subjectId, int marks)
        //{
        //    this.marksId = marksId;
        //    this.studentId = studentId;
        //    this.subjectId = subjectId;
        //    this.marks = marks;
        //}
    }
}

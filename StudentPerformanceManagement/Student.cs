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

        public Student(int studentId, int rollNo, string name, string email, string address, int courseId)
        {
            this.studentId = studentId;
            this.rollNo = rollNo;
            this.name = name;
            this.email = email;
            this.address = address;
            this.courseId = courseId;
        }
    }
}

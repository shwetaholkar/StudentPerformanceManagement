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

        public Marks(int marksId, int studentId, int subjectId, int marks)
        {
            this.marksId = marksId;
            this.studentId = studentId;
            this.subjectId = subjectId;
            this.marks = marks;
        }
    }
}

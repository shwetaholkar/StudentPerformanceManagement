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

        public Subject(int subjectId, int subjectCode, string title, string desc, int courseId)
        {
            this.subjectId = subjectId;
            this.subjectCode = subjectCode;
            this.title = title;
            this.desc = desc;
            this.courseId = courseId;
        }
    }
}

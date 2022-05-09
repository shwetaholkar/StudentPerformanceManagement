using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement
{
    public class Menu
    {
        public void Start()
        {
            CourseService courseService = new CourseService();
            StudentService studentService = new StudentService();
            SubjectService subjectService = new SubjectService();
            MarksService marksService = new MarksService();
            Course c = new Course();
            Student s = new Student();
            Subject subject = new Subject();
            int num = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine(" 1. Add Student ");
                Console.WriteLine(" 2. Add course ");
                Console.WriteLine(" 3. Add subject ");
                Console.WriteLine(" 4. Enter marks of student ");
                Console.WriteLine(" 5. Edit Student data");
                Console.WriteLine(" 6. Edit course ");
                Console.WriteLine(" 7. Edit subject ");
                Console.WriteLine(" 8. Delete Student ");
                Console.WriteLine(" 9. Delete Subject ");
                Console.WriteLine(" 10. Delete Course ");
                Console.WriteLine(" 11. Delete marks ");
                Console.WriteLine(" 12. List all students with details of course, subject, and total marks ");
                Console.WriteLine(" 13.Ask roll number to display subject wise marks for a student ");
                Console.WriteLine(" 14. List course wise average marks ");
                Console.WriteLine(" 15. List course wise max marks ");
                Console.WriteLine(" 16. List course wise topper ");
                //Console.WriteLine(" 0. Exit ");
                Console.WriteLine(" Enter your choice : ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        s.LoadDataForStudent();
                        studentService.Add(s);
                        break;
                    case 2:
                        //Course course = new Course();
                        c.LoadData();
                        courseService.Add(c);
                        break;
                    case 3:
                        subject.LoadDateForSubject();
                        subjectService.Add(subject);
                        break;
                    case 4:
                        marksService.Add();
                        break;
                    case 5:
                        s.EditStudentData();
                        studentService.Edit(s);
                        break;
                    case 6:
                        c.EditCourseData();
                        courseService.Edit(c);
                        break;
                    case 7:
                        subject.EditSubjectData();
                        subjectService.Edit(subject);
                        break;
                    case 8:
                        studentService.Delete(s);
                        break;
                    case 9:
                        subjectService.Delete(subject);
                        break;
                    case 10:
                        courseService.Delete(c);
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        courseService.DisplayCourseWiseAverageMarks();
                        break;
                    case 15:
                        courseService.DisplayCourseWiseHighestMarks();
                        break;
                    case 16:
                        courseService.DisplayCourseWiseTopper();
                        break;
                    //case 0:
                    //    Environment.Exit(0);
                    //    break;
                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;

                }

            } while (num > 0);

        }
    }
}

// See https://aka.ms/new-console-template for more information
using StudentPerformanceManagement;

CourseService courseService = new CourseService();
StudentService studentService = new StudentService();
SubjectService subjectService = new SubjectService();
MarksService marksService = new MarksService();
//courseService.Add();
//studentService.Add();
//subjectService.Add();
marksService.Add();



//Test3();

//void Test3()
//{
//    var num = "0";
//    do
//    {

//        Console.WriteLine(" 1. Add Student Record ");
//        Console.WriteLine(" 2. Update Record ");
//        Console.WriteLine(" 3. Display any student record ");
//        Console.WriteLine(" 4. Display all student record ");
//        Console.WriteLine(" 5. Add Module ");
//        Console.WriteLine(" 6. Display any module details ");
//        Console.WriteLine(" 7. Display all module details ");
//        Console.WriteLine(" 8. Update module ");
//        Console.WriteLine(" 9. Find Total marks ");
//        Console.WriteLine(" 0. Exit ");
//        Console.WriteLine(" Enter your choice : ");
//        num = Console.ReadLine();
//        List<StudentInfo> students = new List<StudentInfo>();
//        List<ModuleInfo> modules = new List<ModuleInfo>();



//        if (num == "1")
//        {

//            Console.Write("Enter Student Rollno :");
//            var rno = Console.ReadLine();

//            Console.Write(" Enter Student Name :");
//            var name = Console.ReadLine();

//            Console.Write("Enter Student Date of birth :");
//            var dob = Console.ReadLine();

//            Console.Write("Enter Student Total Marks :");
//            var totalmarks = Console.ReadLine();

//            var student = new StudentInfo(int.Parse(rno), name, DateTime.Parse(dob), int.Parse(totalmarks));
//            students.Add(student);


//        }
//        else if (num == "2")
//        {





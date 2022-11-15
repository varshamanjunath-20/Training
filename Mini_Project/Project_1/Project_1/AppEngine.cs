using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    class AppEngine
    {
        public void introduce()
        {
            Register.register1();
        }
        public void ADO_Course()
        {
            Introduce.Introduce2();
        }
        public void Display_student()
        {
            Register.Selectdata();
        }
        public void Display_Course()
        {
            Introduce.Select();
        }
        //public void Introduce(Course course)
        //{
        //    Course courseobj = new Course();
        //    //int Course_id;
        //    //string Course_name;
        //    //float Duration, Fees;
        //    Console.WriteLine("Enter the number of students you want to enter: ");
        //    int count = Convert.ToInt32(Console.ReadLine());
        //    for (int v = 0; v <= count - 1; v++)
        //    {
        //        Console.WriteLine("Enter the course details :");
        //        Console.WriteLine("Enter the course id :");
        //        int Course_id = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Enter the course name");
        //        string Course_name = Console.ReadLine();
        //        Console.WriteLine("Enter the course duration");
        //        float Duration = float.Parse(Console.ReadLine());
        //        Console.WriteLine("Enter the course fees :");
        //        float Fees = float.Parse(Console.ReadLine());
        //        Info i3 = new Info();
        //        i3.Display(course);
        //    }
        //}
        //public void Register(Student student)
        //{
        //    Console.Write("Enter the total number of students : ");
        //    int StdCount = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i <= StdCount - 1; i++)
        //    {
        //        Student std = new Student();
        //        Console.Write("Enter the id of student {0} : ", i + 1);
        //        int Id = Convert.ToInt32(Console.ReadLine());
        //        std.Id = Id;
        //        Console.Write("Enter the Name of student {0} : ", i + 1);
        //        string name = Console.ReadLine();
        //        std.name = name;
        //        Console.Write("Enter the DOB of Student {0} : ", i + 1);
        //        DateTime DOB = Convert.ToDateTime(Console.ReadLine());
        //        std.DOB = DOB;
        //        Info i4 = new Info();
        //        i4.Display(student);
        //    }
        //}
        //public static Student[] listOfStudents()
        //{
            
        //}
        //public static Course[] listOfCourses()
        //{

        //}
        //public void enroll(Student student, Course course)
        //{
        //    Console.WriteLine("Enter the student Id : ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the student name :");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter the student date of birth");
        //    DateTime DOB = Convert.ToDateTime(Console.ReadLine());
        //    Console.WriteLine("Enter the course id :");
        //    int Course_id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the course name :");
        //    string Course_name = Console.ReadLine();
        //    Console.WriteLine("Enter the course duration :");
        //    float Duration = float.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter the Fees for the course :");
        //    float Fees = float.Parse(Console.ReadLine());
        //}

        //public Enroll[] listOfEnrollments()
        //{
        //    List<Enroll> enroll = new List<Enroll>();
        //    Info i4 = new Info();
        //    i4.Display
        //        }

    }
}

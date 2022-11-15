using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{ 
    public abstract class Case_study3
    {
        public void showFirstScreen()
        {
                Console.WriteLine("Welcome to SMS(Student Mgmt. System) v0.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:showAdminScreen();
                        break;
                }
            
        }
        public void showStudentScreen()
        {
                Console.WriteLine("Are you an existing student choose : \n1. To see all the student list ");
                Console.WriteLine("Do you want to Register :\n 2. student register screen \n 3.go back");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        break;
                    case 2:
                        showStudentRegistrationScreen();
                        break;
                    case 3:
                        showFirstScreen();
                        break;
                }
            
        }
        public void showAdminScreen()
        {
                Console.WriteLine("Welcome back Admin..!!!");
                Console.WriteLine("Do you like to add more student details ??? :");
                Console.WriteLine("Enter 1 to register new student :\n 1. studentregister form\n" +
                    "enter 2 to add new courses :\n 2. introduce new courses, \n3. To see all the courses," +
                    "\n 4. Go back : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showStudentRegistrationScreen();
                        break;
                    case 2:
                        introduceNewCourseScreen();
                        break;
                    case 3:
                    showAllCoursesScreen();
                    break;
                    case 4:
                        showFirstScreen();
                        break;
                }
                
        }
		 public void showAllStudentsScreen()
         {
            AppEngine app3 = new AppEngine();
            app3.Display_student();
            
         }
		 public void showStudentRegistrationScreen()
        {
            AppEngine app1 = new AppEngine();
            app1.introduce();
        }
		 public void introduceNewCourseScreen()
        {
            AppEngine app2 = new AppEngine();
            app2.ADO_Course();
        }
		 public void showAllCoursesScreen()
        {
            AppEngine a = new AppEngine();
            a.Display_Course();

        }
	}
}


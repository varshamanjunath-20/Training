using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    /*Create class Info. Write a method called as:
	public void display(Student student) {
		//Code here to display the details of given student}
    Modify Info class by adding one more method:
	public void display(Course course) {
		//Code here to display the details of given course
	}*/
    class Info
    {
        public void Display(Student student)
        {

            Console.WriteLine("student id :{0}", student.Id);
            Console.WriteLine("student name :{0} ", student.name);
            Console.WriteLine("student dob :{0} ", student.DOB.ToShortDateString());

        }
        public void Display(Course course)
        {
            Console.WriteLine("course id {0} : ", course.Course_id);
            Console.WriteLine("course name {0}: ", course.Course_name);
            Console.WriteLine("course duration{0} : ", course.Duration + "years");
            Console.WriteLine("Fees {0}: ", course.Fees + "lakhs");
        }
        public void Display(Enroll enroll)
        {
            Console.WriteLine("student :{0}", enroll.student);
            Console.WriteLine("Course :{0} ", enroll.course);
            Console.WriteLine("enrollment date :{0} ", enroll.enrollmentDate);

        }
    }
}

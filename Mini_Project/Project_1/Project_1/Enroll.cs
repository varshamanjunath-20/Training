using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    //Create Enroll class with the following structure:
    //public class Enroll {private Student student;
    //private Course course;
    //private LocalDate enrollmentDate;
    //constructors & getters/setters}
    class Enroll
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public DateTime enrollmentDate { get; set; }

        public Enroll()
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }


    }
    //Next create AppEngine class which will contain the following methods:
    //Write App class with main method to test the above functionalities
    //Now modify Info class by adding new methods for displaying Enrollment details
}

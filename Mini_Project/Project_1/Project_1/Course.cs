using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Casestudy1
{
    /*Now  create Course class (id, name, duration, fees)
  - Modify Info class by adding one more method:
	public void display(Course course) {
		//Code here to display the details of given course}*/
    class Course
    {
        public int Course_id { get; set; }
        public string Course_name{ get; set; }
        public float Duration{get; set; }
        public float Fees{get; set; }
        //public Course(int id,string name,float dur, float fees)
        //{
        //    Course_id = id;
        //    Course_name = name;
        //    Duration = dur;
        //    Fees = fees;
        //}
    }
}

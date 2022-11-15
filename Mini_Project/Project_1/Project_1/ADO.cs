using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Infinite_Casestudy1
{
    public class Register
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("data source=ICS-LAP-6624;initial catalog=MINI_PROJECT;" +
                "Integrated Security=True");
            con.Open();
            return con;
        }
        public static void register1()
        {
            con = GetConnection();
            Console.WriteLine("Enter the student id, name, date of birth");
            int Id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            DateTime DOB = Convert.ToDateTime(Console.ReadLine());
            cmd = new SqlCommand("insert into Student values(@id,@name,@dob)", con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", DOB);
            int v = cmd.ExecuteNonQuery();

            if (v > 0)
            {
                Console.WriteLine("Registered successfully....");
            }
            else
            {
                Console.WriteLine("something went wrong");
            }
        }
        public static void Selectdata()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }
        }
    }
}


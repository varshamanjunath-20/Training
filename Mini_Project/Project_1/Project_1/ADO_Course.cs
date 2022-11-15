using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Infinite_Casestudy1
{
    public class Introduce
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
            public static void Introduce2()
            {
                con = GetConnection();
                Console.WriteLine("Enter the course id, name, duration and fees : ");
                int Course_id = Convert.ToInt32(Console.ReadLine());
                string Course_name = Console.ReadLine();
                float Duration = float.Parse(Console.ReadLine());
                float Fees = float.Parse(Console.ReadLine());
                cmd = new SqlCommand("insert into course values(@id,@name,@duration,@fees)", con);
                cmd.Parameters.AddWithValue("@id", Course_id);
                cmd.Parameters.AddWithValue("@name", Course_name);
                cmd.Parameters.AddWithValue("@duration", Duration);
                cmd.Parameters.AddWithValue("@fees", Fees);
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    Console.WriteLine("Course Added successfully....");
                }
                else
                {
                    Console.WriteLine("something went wrong");
                }
            }
            public static void Select()
            {
                con = GetConnection();
                cmd = new SqlCommand("select * from course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
                }
            }
        }
    }

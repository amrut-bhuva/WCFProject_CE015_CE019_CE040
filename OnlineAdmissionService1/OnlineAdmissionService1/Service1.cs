using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace OnlineAdmissionService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public getmerit Merit()
        {
            getmerit gd = new getmerit();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DDIT CE\Sem 6\SOC\Project\OnlineAdmissionService1\Host\StuDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select name,merit from Student order by [merit] DESC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Table");
            da.Fill(dt);
            gd.merit = dt;
            con.Close();
            return (gd);
        }

        public string RegisterStudent(Student s)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DDIT CE\Sem 6\SOC\Project\OnlineAdmissionService1\Host\StuDB.mdf;Integrated Security=True");
            con.Open();
            string query = "select email from Student where email = @Email";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.Parameters.AddWithValue("@Email", s.Email);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.HasRows)
            {
                msg = "Student Already Exists!";
            }
            else
            {
                dr.Close();
                string q = "insert into Student(name,email,mobile,pcm,gujcet,merit) values(@Name,@Email,@Mo,@Pcm,@Guj,@Merit)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Email", s.Email);
                cmd.Parameters.AddWithValue("@Mo", s.Mo);
                cmd.Parameters.AddWithValue("@Pcm", s.Pcm);
                cmd.Parameters.AddWithValue("@Guj", s.Guj);
                double merit = 0.6 * (s.Pcm / 3) + 0.4 * (s.Guj * 0.83);
                cmd.Parameters.AddWithValue("@Merit", merit);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    msg = "Registered Successfully!";
                }
                else
                {
                    msg = "Failed to Register!";
                }
            }
            con.Close();
            return (msg);
        }

        public string ValidateUser(string username, string password)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DDIT CE\Sem 6\SOC\Project\OnlineAdmissionService1\Host\StuDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (username.Equals(dr["email"]) && password.Equals(dr["mobile"]))
                {
                    msg = "true";
                    break;
                }
                else
                {
                    msg = "false";
                }
            }
            dr.Close();
            con.Close();
            return (msg);
        }
    }
}
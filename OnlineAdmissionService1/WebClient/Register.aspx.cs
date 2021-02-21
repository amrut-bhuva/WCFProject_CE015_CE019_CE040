using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ServiceReference1;
namespace WebClient
{
    public partial class Register : System.Web.UI.Page
    {
        ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = ptname.Text;
            s.Email = ptemail.Text;
            s.Mo = ptcontact.Text;
            s.Pcm = Int32.Parse(pcm.Text);
            s.Guj = Int32.Parse(guj.Text);
            string msg = service1.RegisterStudent(s);
            errreg.Text = msg.ToString();
            Response.Redirect("Login.aspx");
        }
    }
}
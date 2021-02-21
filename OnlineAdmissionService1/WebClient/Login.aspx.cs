using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnplogin_Click(object sender, EventArgs e)
        {
            string useremail = plemail.Text;
            string password = plpasswd.Text;
            string res = service1.ValidateUser(useremail, password);
            if (res.Equals("true"))
            {
                Session.RemoveAll();
                Session["curruser"] = plemail.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                errplogin.Text = "Invalid Credential!";
            }
        }
    }
}
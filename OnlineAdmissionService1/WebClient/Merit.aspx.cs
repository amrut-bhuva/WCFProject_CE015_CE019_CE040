using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebClient
{
    public partial class Merit : System.Web.UI.Page
    {
        ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            ServiceReference1.getmerit m = new ServiceReference1.getmerit();
            m = service1.Merit();
            d = m.merit;
            gridview.DataSource = d;
            gridview.DataBind();
        }
    }
}
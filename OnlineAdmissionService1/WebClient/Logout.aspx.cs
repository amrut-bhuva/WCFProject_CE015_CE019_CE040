﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session["curruser"] = null;
            Session.RemoveAll();
            Response.Redirect("Default");
        }
    }
}
﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using System.Xml.Linq;

public partial class Admin_adminmaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            string user = Convert.ToString(Session["adminusername"]);
            if (lbllog.Text == "Log In" && user != "")
            {

                
                lbllog.Text ="Log Out";

            }
        }
    }
}

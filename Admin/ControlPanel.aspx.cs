using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ControlPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbluserid.Text = Convert.ToString(Session["adminusername"]);
        if (lbluserid.Text == "")
        {
            Response.Redirect("~/admin/adminlogin.aspx");
        }
    }
    protected void btnmanageusers_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/managesusers.aspx");
    }

    protected void btnmanageitemlist_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/manageItems.aspx");
    }
    protected void btnaddplace_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/addplace.aspx");
    }
    protected void btnvieworders_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/manageorders.aspx");
    }
    protected void btnviewtransection_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/managetransection.aspx");
    }
    protected void btnchangepassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/changadminpassword.aspx");
    }
    protected void btnmanagesstock_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin/managestock.aspx");
    }
}
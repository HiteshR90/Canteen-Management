using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
//using System.Xml.Linq;

public partial class Admin_adminlogin : System.Web.UI.Page
{
    string username;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
       
       Session["adminusername"] = "";
       Session["login"] = "Log In";
       if (IsPostBack == false)
        {
            Session.Abandon();
           clear();
        }
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        SqlDataAdapter adlog = new SqlDataAdapter("select adminid from admin_data where (adminusername='" + txtusername.Text + "' OR emailid='" + txtusername.Text + "') AND password='"+txtpassword.Text+"'", cn);
        DataSet dst = new DataSet();
        adlog.Fill(dst);

        if (dst.Tables[0].Rows.Count == 0)
        {
            lblerror.Text = "Login Failed.Try Again!!";
        }
        else
        {
            // username = dst.Tables[0].Rows[0][2].ToString();
            //password = dst.Tables["admin_data"].Rows[0][6].ToString();
            Session["adminusername"] = txtusername.Text;
            //string sess = Convert.ToString(Session["username"]);
            username = txtusername.Text;
            Session["adminpass"] = txtpassword.Text;
            Session["logout"] = "Log Out";
            clear();
            Response.Write("succ");
            Response.Redirect("~/admin/controlpanel.aspx?="+username);
        }
    }
    protected void btncancle_Click(object sender, EventArgs e)
    {
        clear();
    }
    public void clear()
    {
        txtpassword.Text = "";
        txtusername.Text = "";
        lblerror.Text = "";
    }
}

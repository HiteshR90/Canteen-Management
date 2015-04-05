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

public partial class Admin_ChangAdminpassword : System.Web.UI.Page
{
    string username;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        username = Convert.ToString(Session["adminusername"]);
        lbluserid.Text = username;
        if (IsPostBack == false)
        {
            clear();
        }
        if (username == "")
        {
            Response.Redirect("~/admin/adminlogin.aspx");
        }
    }
    protected void btnChangepass_Click(object sender, EventArgs e)
    {
        SqlDataAdapter ad = new SqlDataAdapter("select password from admin_data where adminusername='"+username+"'",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);

        if (dst.Tables[0].Rows.Count > 0)
        {
            string pass = Convert.ToString(Session["adminpass"]);
            if (txtcureenpass.Text == pass)
            {
                if (txtconfpass.Text == txtnewpass.Text)
                {
                    SqlCommand cmd = new SqlCommand("update admin_data set password='"+txtconfpass.Text+"' where adminusername='"+username+"' ",cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    Response.Redirect("~/admin/controlpanel.aspx");
                }
                else
                {
                    lblerror.Text = "Your new Password Does Not Match!!!";
                }
            }
            else
            {
            lblerror.Text = "You Enter Wrong Current Password!!";
            }

        }
        }
        
    

    protected void btncancel_Click(object sender, EventArgs e)
    {

        clear();
    }
    public void clear()
    {
        txtcureenpass.Text = "";
        txtconfpass.Text = "";
        txtnewpass.Text = "";
    }
}

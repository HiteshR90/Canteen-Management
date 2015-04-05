using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.Configuration;
using cnteeenbind;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;


public partial class Forgotpassword : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    
    datacollect datacoll;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
            datacoll = new datacollect();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
    protected void btnEmail_Click(object sender, EventArgs e)
    {
        SqlDataAdapter ad = new SqlDataAdapter("select * from admin_data where adminusername='"+txtusername.Text+"' AND emailid='"+txtemailid.Text+"'",cn);

        DataSet dst = new DataSet();
        ad.Fill(dst);

        if (dst.Tables[0].Rows.Count > 0)
        {
            string pass=Convert.ToString(dst.Tables[0].Rows[0][3]);

            string returnpassword="your password is ==>" + pass;
            
            datacoll.sendmail(txtemailid.Text, "Forgot Password", returnpassword);
            
        }
        else
        {
            lblerror.Text = "Your EmailID AND UserName Not Match!!! ";
        }
    }
}

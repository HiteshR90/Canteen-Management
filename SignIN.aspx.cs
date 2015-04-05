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
//using System.Xml.Linq;
using System.Web.Configuration;
using cnteeenbind;


public partial class SignIN : System.Web.UI.Page
{
    datacollect datacoll;
    //string userid;
    string username;
    string con;
    
   
    protected void Page_Load(object sender, EventArgs e)
    {
        con = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        datacoll = new datacollect(con);
        Session["username"] = "";
        Session["login"]="Log In";
        if (IsPostBack == false)
        {
            Session.Abandon();
        }
    }

    public void clear()
    {
        txtpassword.Text = "";
        txtusernameoremail.Text = "";
    }
    
    protected void btnlogin_Click1(object sender, EventArgs e)
    {
        
        //string password;
        DataSet dst = new DataSet();
        dst = datacoll.login(txtusernameoremail.Text,txtusernameoremail.Text,txtpassword.Text);

        if (dst.Tables["customerdata"].Rows.Count == 0)
        {
            lblerror.Text = "Login Failed.Try Again!!";
        }

        else
        { 
            username=dst.Tables["customerdata"].Rows[0]["username"].ToString();
            //password = dst.Tables["customerdata"].Rows[0][6].ToString();
            Session["username"]=username;
            string sess=Convert.ToString(Session["username"]);
            Session["psw"] = txtpassword.Text;
            Session["logout"]="Log Out";
            Response.Redirect("home.aspx?username="+username);
            
        }

        
    }
}

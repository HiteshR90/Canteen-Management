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

public partial class changepassword : System.Web.UI.Page
{
    datacollect datacoll;
    string con, username;
    protected void Page_Load(object sender, EventArgs e)
    {
        //username = Request.QueryString["username"].ToString();
        username = Convert.ToString(Session["username"]);
        UserNameLabel.Text = username;
        try
        {
            con = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            datacoll = new datacollect(con);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
    protected void btnregister_Click(object sender, EventArgs e)
    {
        
        datacoll = new datacollect(con);
        DataSet dst = new DataSet();

        dst = datacoll.login_check_available(UserNameLabel.Text,UserNameLabel.Text);
        if (dst.Tables[0].Rows.Count > 0)
        {
            string st=Convert.ToString(Session["psw"]);
            if (txtcurrentpassword.Text == st)
            {
                if (txtnewpassword.Text == txtconfirmpassword.Text)
                {
                    datacoll.change_password(username, txtnewpassword.Text);
                    Session["psw"] = txtconfirmpassword.Text;
                    Response.Redirect("~/menucardf.aspx?username=" + username);
                }
            }
            else
            {
                errmsgLabel.Text = "Sorry! Password is wrong.";
                errmsgLabel.Visible = true;
            }
        }

        else
        {
            errmsgLabel.Text = "Sorry! Password is wrong.";
            errmsgLabel.Visible = true;
        }
    }
    protected void LogOutLinkButton_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/home.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/menucardf.aspx?username="+username);
    }
}

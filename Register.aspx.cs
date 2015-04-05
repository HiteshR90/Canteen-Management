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
using System.Data.SqlClient;
using System.Web.Configuration;
using cnteeenbind;


public partial class Register : System.Web.UI.Page
{
    string con;
    datacollect objcollect;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        objcollect = new datacollect(con);
        if (IsPostBack == false)
        {
            user();
           
        }
    }

   
    
   
    protected void user()
    {
        ddlusertype.Items.Insert(0,"--Select--");
        ddlusertype.Items.Insert(1,"Staff");
        ddlusertype.Items.Insert(2, "Student");
        branch();
    }
    protected void branch()
    {
        ddlbranch.Items.Insert(0,"--Select--");
        ddlbranch.Items.Insert(1,"CSE");
        ddlbranch.Items.Insert(2,"IT");
        ddlbranch.Items.Insert(3,"EC");
        ddlbranch.Items.Insert(4,"ME");
        ddlbranch.Items.Insert(5,"EE");
        semester();
    }
    protected void semester()
    {
        ddlsemester.Items.Insert(0,"--Select--");
        ddlsemester.Items.Insert(1,"1");
        ddlsemester.Items.Insert(2,"2");
        ddlsemester.Items.Insert(3,"3");
        ddlsemester.Items.Insert(4,"4");
        ddlsemester.Items.Insert(5,"5");
        ddlsemester.Items.Insert(6,"6");
        ddlsemester.Items.Insert(7,"7");
        ddlsemester.Items.Insert(8, "8");
    }
    protected void ddlusertype_SelectedIndexChanged(object sender, EventArgs e)
    {
        
            select();
    }
    public void select()
    {
        if (Convert.ToInt32(ddlusertype.SelectedIndex) == 1)
        {
            ddlsemester.Visible = false;
        }
        else
        {
            ddlsemester.Visible = true;
        }
    }
    protected void btnregister_Click(object sender, EventArgs e)
    {
       // if (Captcha.CaptchaCode == txtcaptcha.Text)
        {
            try
            {
                DataSet dst = new DataSet();
                dst = objcollect.login_check_available(txtusername.Text, txtemailid.Text);
                int check = dst.Tables["customerdata"].Rows.Count;
                if (check == 0)
                {
                    Random ran = new Random();
                    int intpass = ran.Next(0,10000);
                    string pass = Convert.ToString(intpass);
                    objcollect.sendmail(txtemailid.Text, "Password", "your password is==>" + pass);
                    objcollect.sendSMS(txtphoneno.Text, "your password is==>" + pass);
                    if (ddlusertype.SelectedIndex == 1)
                    {
                       // Response.Write("staff");
                       objcollect.register(txtfname.Text, txtlname.Text, txtusername.Text, txtemailid.Text, pass, ddlusertype.Text, ddlbranch.Text, " ", txtphoneno.Text);
                    }
                    else if (ddlusertype.SelectedIndex == 2)
                    {
                        //Response.Write("student");
                        objcollect.register(txtfname.Text, txtlname.Text, txtusername.Text, txtemailid.Text, pass, ddlusertype.Text, ddlbranch.Text, ddlsemester.Text, txtphoneno.Text);
                    }
                     //Session["fname"] = txtfname.Text;
                    //Session["username"] = txtusername.Text;
                    
                    lblerrormessage.Text = "Check Your Mail For Password or sms";

                    clear();
                }

                else
                {

                    lblerrormessage.Text = "Enter Differnt User Name Or Email ID";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        //else
        {
            //lblerrormessage.Text = "You Are Not Human";
        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {

        clear();
    }
    public void clear()
    {
        txtemailid.Text = "";
        txtfname.Text = "";
        txtlname.Text = "";
        //txtpassword.Text = "";
        //txtrepassword.Text = "";
        txtusername.Text = "";
        txtphoneno.Text = "";
        ddlusertype.SelectedValue = "--Select--";
        ddlbranch.SelectedValue = "--Select--";
        ddlsemester.SelectedValue = "--Select--";
    }


    
}

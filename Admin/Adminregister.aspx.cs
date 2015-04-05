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
using cnteeenbind;

//using System.Xml.Linq;

public partial class Admin_Adminregister : System.Web.UI.Page
{
    datacollect canteen;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        lblname.Text = Convert.ToString(Session["adminusername"]);
        if (lblname.Text == "")
        {
            Response.Redirect("~/admin/adminlogin.aspx");
        }
        canteen = new datacollect();
    }
    protected void btnregister_Click(object sender, EventArgs e)
    {
        string date;
        DateTime dt;
        SqlCommand cmddate = new SqlCommand("Select GetDate()",cn);
        cn.Open();
        dt = (DateTime)cmddate.ExecuteScalar();
        cn.Close();
        date = Convert.ToString(dt);

        SqlDataAdapter adcheck = new SqlDataAdapter("select adminid from admin_data where adminusername='"+txtusername.Text+"' OR emailid='"+txtemail.Text+"'",cn);
        DataSet dst = new DataSet();
        adcheck.Fill(dst);
        
            if (dst.Tables[0].Rows.Count == 0)
            {
                Random ran = new Random();
                int randompass = ran.Next(0,100000);
                string password = Convert.ToString(randompass);

                canteen.sendmail(txtemail.Text, "Admin Password", "your Password is==>" + password + "<== After Login You can change your password");
                SqlCommand cmd = new SqlCommand("insert into admin_data (adminusername,emailid,password,fname,lname,phoneno,datetime) values ('" + txtusername.Text + "','" + txtemail.Text + "','" + password + "','" + txtfname.Text + "','" + txtlname.Text + "','" + txtphoneno.Text + "','" + date + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                lblerror.Text = "Check our Email For Password";
                //Response.Redirect("~/admin/controlpanel.aspx");
            }

            else
            {
                lblerror.Text = "User Name Or EmailId Already Exist!!";
            }
        
       
    }
}

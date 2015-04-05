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
using System.Web.Mail;
using cnteeenbind;

public partial class Contactus : System.Web.UI.Page
{
    datacollect data;
    protected void Page_Load(object sender, EventArgs e)
    {
        data = new datacollect();
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        data.sendmail("gardicanteen@gmail.com", "From_" + txtemail.Text + "_" + txtname.Text,"Phone No==>"+txtphone.Text+" >>>Message==>"+ txtmessage.Text);
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtemail.Text = "";
        txtname.Text = "";
        txtphone.Text = "";
        txtmessage.Text = "";
    }
}

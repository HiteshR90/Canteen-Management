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

public partial class managetransection : System.Web.UI.Page
{
    datacollect datacoll;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    string uid,con;
    protected void Page_Load(object sender, EventArgs e)
    {
        lbluname.Text = Convert.ToString(Session["adminusername"]);
        if (lbluname.Text == "")
        {
            Response.Redirect(@"~/admin/default.aspx");
        }
        else
        {
            if (IsPostBack == false)
            {
                hide_all();
            }

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
    }

    public void hide_all()
    {
        griduserdata.Visible = false;
        gridalldata.Visible = false;
        btnviewbyusername.Visible = false;
        btnviewalltransection.Visible = false;
        ddlusername.Visible = false;
        txtamount.Visible = false;
        btnfillamount.Visible = false;
        ddlusernameaddamount.Visible = false;
        lblinseramount.Visible = false;
        lblusername.Visible = false;
        lblbalancecurrent.Visible = false;
        lblbalance.Visible = false;
    }
    protected void btnviewtodaytarnsection_Click(object sender, EventArgs e)
    {
        griduserdata.Visible = false;
        gridalldata.Visible = false;
        lblerror.Text = "";
        lblbalancecurrent.Visible = false;
        lblbalance.Visible = false;
        btnviewbyusername.Visible = true;
        btnviewalltransection.Visible = true;
        ddlusername.Visible = false;
        ddlusernameaddamount.Visible = false;
        txtamount.Visible = false;
        lblusername.Visible = false;
        lblinseramount.Visible = false;
        btnfillamount.Visible = false;
    }
    protected void btnviewbyusername_Click(object sender, EventArgs e)
    {

        griduserdata.Visible = false;
        gridalldata.Visible = false;
        lblerror.Text = "";
        ddlusername.Visible = true;
        ddlusernameaddamount.Visible = false;
        txtamount.Visible = false;
        btnfillamount.Visible = false;
        fii_ddluser_name();
    }

    public void fii_ddluser_name()
    {
        SqlDataAdapter ad = new SqlDataAdapter("select username from customerdata", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlusername.DataTextField = "username";
        ddlusername.DataSource = dst;
        ddlusername.DataBind();
    }
    protected void btnviewalltransection_Click(object sender, EventArgs e)
    {
        griduserdata.Visible = false;
        gridalldata.Visible = true;
        lblerror.Text = "";
        ddlusername.Visible = false;
        griduserdata.Visible = false;

        //SqlDataAdapter ad = new SqlDataAdapter("SELECT Transection.TID, Order_tb.ItemName, Order_tb.QTY, Order_tb.Price, Order_tb.Orderdate, Order_tb.OrderTime, Transection.Amount, Transection.Balance, customerdata.UserName FROM customerdata INNER JOIN Order_tb ON customerdata.UserID = Order_tb.UserId INNER JOIN Transection ON customerdata.UserID = Transection.UserID where transection.amount>0",cn);
        SqlDataAdapter ad = new SqlDataAdapter("SELECT customerdata.UserName, Transection.TID, Transection.Time, Transection.date, Transection.Amount, Transection.Balance, Order_tb.ItemName, Order_tb.Price, Order_tb.QTY FROM Transection INNER JOIN Order_tb ON Transection.OrderID = Order_tb.OrderID INNER JOIN customerdata ON Transection.UserID = customerdata.UserID where Transection.orderid=Order_tb.OrderID ", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        gridalldata.DataSource = dst;
        gridalldata.DataBind();

    }
    protected void btnaddammounttouser_Click(object sender, EventArgs e)
    {
        griduserdata.Visible = false;
        gridalldata.Visible = false;
        lblerror.Text = "";
        lblinseramount.Visible = true;
        lblusername.Visible = true;
        lblbalance.Visible = true;
        lblbalancecurrent.Visible = true;
        btnviewbyusername.Visible = false;
        btnviewalltransection.Visible = false;
        ddlusername.Visible = false;
        txtamount.Visible = true;
        btnfillamount.Visible = true;
        SqlDataAdapter ad = new SqlDataAdapter("select username from customerdata", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlusernameaddamount.DataTextField = "username";
        ddlusernameaddamount.DataSource = dst;
        ddlusernameaddamount.DataBind();
        ddlusernameaddamount.Visible = true;

    }
    protected void ddlusername_SelectedIndexChanged(object sender, EventArgs e)
    {
        griduserdata.Visible = true;
        gridalldata.Visible = false;
        lblerror.Text = "";
        uid = "";

        SqlDataAdapter ad = new SqlDataAdapter("select userid from customerdata where username='"+ddlusername.SelectedItem+"'",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        uid = dst.Tables[0].Rows[0][0].ToString();

        SqlDataAdapter adg = new SqlDataAdapter("SELECT Transection.TID, Order_tb.ItemName, Order_tb.Price, Order_tb.QTY, Transection.Amount, Transection.Balance, Transection.date, Transection.Time FROM  Transection INNER JOIN Order_tb ON Transection.OrderID = Order_tb.OrderID where Transection.orderid=Order_tb.orderid AND Transection.userid='"+Convert.ToInt16(uid)+"'", cn);
        DataSet dstg = new DataSet();
        adg.Fill(dstg);
        
        griduserdata.DataSource = dstg;
        griduserdata.DataBind();
    }
    protected void btnfillamount_Click(object sender, EventArgs e)
    {
        lblerror.Text = "";
        uid="";
         SqlDataAdapter ad = new SqlDataAdapter("select userid from customerdata where username='"+ddlusernameaddamount.SelectedItem+"'",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        uid = dst.Tables[0].Rows[0][0].ToString();

        string def = "";
        String date = Convert.ToString(string.Format("{0:dd/MM/yyyy}", datacoll.add_date_time()));
        String time = Convert.ToString(string.Format("{0:T}", datacoll.add_date_time()));

        int bal=0;
        SqlDataAdapter adm = new SqlDataAdapter("select balance from transection where userid='" + Convert.ToString(uid) + "' ORDER BY tid DESC", cn);
        DataSet dstm = new DataSet();
        adm.Fill(dstm);
        if (dstm.Tables[0].Rows.Count > 0)
        {
            bal = Convert.ToInt16(dstm.Tables[0].Rows[0][0].ToString());
        }
        else
        {
            bal = 0;
        }

        if (txtamount.Text == "")
        {
            //bal = 0;
        }
        else
        {
            bal += Convert.ToInt16(txtamount.Text);
        }
        
        SqlCommand cmd = new SqlCommand("insert into transection (orderid,userid,time,date,amount,balance) values ('"+def+"','"+Convert.ToInt16(uid)+"','"+time+"','"+date+"','"+def+"','"+bal+"')",cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

        btnfillamount.Visible = false;
        txtamount.Visible = false;
        lblbalancecurrent.Visible = false;
        lblbalance.Visible = false;
        lblinseramount.Visible = false;
        lblusername.Visible = false;
        ddlusernameaddamount.Visible = false;
        txtamount.Text = "";
        lblerror.Text = "Sucessfull !!";
    }
    protected void ddlusernameaddamount_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblerror.Text = "";
        uid = "";
        SqlDataAdapter ad = new SqlDataAdapter("select userid from customerdata where username='" + ddlusernameaddamount.SelectedItem + "'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        uid = dst.Tables[0].Rows[0][0].ToString();

        SqlDataAdapter adm = new SqlDataAdapter("select balance from transection where userid='" + Convert.ToString(uid) + "' ORDER BY tid DESC", cn);
        DataSet dstm = new DataSet();
        adm.Fill(dstm);

        if (dstm.Tables[0].Rows.Count > 0)
        {
            lblbalancecurrent.Text = dstm.Tables[0].Rows[0][0].ToString();
        }
        else
        {
            lblbalancecurrent.Text = "your Balance is Null  !!";
        }
    }
}
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
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
using System.Data.SqlClient;


public partial class Admin_ManageOrders : System.Web.UI.Page
{
    datacollect data;
    string con,date;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        lblusername.Text = Convert.ToString(Session["adminusername"]);
        if (lblusername.Text == "")
        {
            Response.Redirect("~/admin/adminlogin.aspx");
        }
        else
        {
            date = txtDate.Text.ToString();
            try
            {
                con = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                data = new datacollect(con);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            if (IsPostBack == false)
            {
                fill_ddl();
                hide_all();
            }
            fill_grid();
            today();
            //Response.Write(txtdate.Text);
        }
    }

   

    public void fill_ddl()
    {
        SqlDataAdapter ad = new SqlDataAdapter("select username from customerdata", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlusernames.DataTextField = "username";
        ddlusernames.DataSource = dst.Tables[0];
        ddlusernames.DataBind();

        
      
    }

    public void fill_grid()
    {

        string uname = Convert.ToString(ddlusernames.SelectedItem);
        SqlDataAdapter adgrv = new SqlDataAdapter("SELECT customerdata.UserName,order_manages_temp.OrderID, order_manages_temp.ItemName, order_manages_temp.Price, order_manages_temp.QTY, order_manages_temp.Place,order_manages_temp.Date, order_manages_temp.Time, order_manages_temp.Total, order_manages_temp.Balance FROM order_manages_temp INNER JOIN customerdata ON order_manages_temp.username = customerdata.username where order_manages_temp.date='" + date + "' AND customerdata.username='" + uname + "'", cn);
        DataSet dstgrv = new DataSet();
        adgrv.Fill(dstgrv);
        gridorderdata.DataSource = dstgrv;
        gridorderdata.DataBind();

    }

   
    
    public void today()
    {
        string date = Convert.ToString(string.Format("{0:dd/MM/yyyy}", data.add_date_time()));
        string uname = Convert.ToString(ddlusernames.SelectedItem);
        SqlDataAdapter ad = new SqlDataAdapter("SELECT        customerdata.UserName,order_manages_temp.OrderID, order_manages_temp.ItemName, order_manages_temp.Price, order_manages_temp.QTY, order_manages_temp.Place,order_manages_temp.Date, order_manages_temp.Time, order_manages_temp.Total, order_manages_temp.Balance FROM            order_manages_temp INNER JOIN customerdata ON order_manages_temp.username = customerdata.username where customerdata.username='" + ddlusernames.SelectedItem + "' AND order_manages_temp.date='" + date + "'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        gridtoday.DataSource = dst;
        gridtoday.DataBind();
    }

    protected void btntoday_Click(object sender, EventArgs e)
    {
        gridtoday.Visible = true;
        btntoday.Visible = false;
        
        btnprint.Visible = true;
        //hide
        lbluname.Visible = true;
        lbldate.Visible = false;
        ddlusernames.Visible = true;
        gridorderdata.Visible = false;
        txtDate.Visible = false;
        btntoday.Visible = true;

        fill_ddl();

       
        today();
    }


    protected void gridorderdata_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        
    }
    protected void btnhide_Click(object sender, EventArgs e)
    {
        btntoday.Visible = true;
        //btnhide.Visible = false;
        gridtoday.Visible = false;
    }




    protected void btnshowbyuser_Click(object sender, EventArgs e)
    {
        lbluname.Visible = true;
        lbldate.Visible = true;
        txtDate.Visible = true;
        ddlusernames.Visible = true;
        
        gridorderdata.Visible = true;
        btntoday.Visible = true;

        //other
        gridtoday.Visible = false;
        btnprint.Visible = false;
        //btnhide.Visible = false;
    }
    protected void btnhideall_Click(object sender, EventArgs e)
    {

        hide_all();
    }

    public void hide_all()
    {
        lbluname.Visible = false;
        gridorderdata.Visible = false;
        gridtoday.Visible = false;
        txtDate.Visible = false;
        ddlusernames.Visible = false;
        btnprint.Visible = false;
        lbldate.Visible = false;
    }

    protected void btnprint_Click(object sender, EventArgs e)
    {
        //hide_all();
        //SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM order_manages_temp where date='" + date + "' AND username='" + ddlusernames.SelectedItem.Text + "'", cn);
        ////SqlDataAdapter ad = new SqlDataAdapter("SELECT customerdata.FName, customerdata.Lname, customerdata.UserName, order_manages_temp.OrderID, order_manages_temp.ItemName, order_manages_temp.Price,order_manages_temp.QTY, order_manages_temp.Place, order_manages_temp.Date, order_manages_temp.Time, order_manages_temp.Total FROM customerdata INNER JOIN order_manages_temp ON customerdata.UserID = order_manages_temp.UserID", cn);
        //DataSet dst = new DataSet();
        //ad.Fill(dst);

        //ReportDocument rp = new ReportDocument();
        //rp.Load(Server.MapPath("~/CrystalReport.rpt"));
        //rp.SetDataSource(dst.Tables[0]);
        //CrystalReportViewer1.ReportSource = rp;
        //CrystalReportViewer1.DataBind();
    }
    protected void ddlusernames_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

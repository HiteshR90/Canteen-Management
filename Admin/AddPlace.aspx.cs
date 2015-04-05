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

public partial class AddPlace : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    string username;
    protected void Page_Load(object sender, EventArgs e)
    {
        username = Convert.ToString(Session["adminusername"]);
        lbluserid.Text = username;
        if (username == "")
        {
            Response.Redirect("~/admin/adminlogin.aspx");
        }
        if(IsPostBack==false)
        {
            hide();
        }
    }

    public void hide()
    {
        btnOkBuilding.Visible = false;
        btnokplace.Visible = false;
        txtbuilding.Visible = false;
        txtplace.Visible = false;
        ddlbuildingnames.Visible = false;
    }

    protected void addBuilding_Click(object sender, EventArgs e)
    {
        btnOkBuilding.Visible = true;
        txtbuilding.Visible = true;
        btnaddBuilding.Visible = false;
        btnaddplace.Visible = true;
        ddlbuildingnames.Visible = false;
        txtplace.Visible = false;
        btnokplace.Visible = false;
    }

    protected void btnaddplace_Click(object sender, EventArgs e)
    {
        fillbuilding();
        ddlbuildingnames.Visible = true;
        btnokplace.Visible = true;
        txtplace.Visible = true;
        btnaddplace.Visible = false;
        btnaddBuilding.Visible = true;
        txtbuilding.Visible = false;
        btnOkBuilding.Visible = false;

    }
    protected void btnOkBuilding_Click(object sender, EventArgs e)
    {
        SqlDataAdapter ad = new SqlDataAdapter("select BuildingID from building where Name='"+txtbuilding.Text+"'",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);

        if (dst.Tables[0].Rows.Count > 0)
        {
            lblerror.Text = "Build Name Already Exist!!!!";
        }
        else
        {
            if (txtbuilding.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into building (name) values ('" + txtbuilding.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                btnaddBuilding.Visible = true;
                txtbuilding.Visible = false;
                btnOkBuilding.Visible = false;
            }
            else
            {
                lblerror.Text = "Please Enter Building Name";
            }
        }
    }
    protected void btnokplace_Click(object sender, EventArgs e)
    {
        SqlDataAdapter ad = new SqlDataAdapter("select placeid from Placee_tb where placeName='" + txtplace.Text + "'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);

        if (dst.Tables[0].Rows.Count > 0)
        {
            lblerror.Text = "Place Name Already Exist!!!!";
        }
        else
        {
            if (txtplace.Text != "")
            {
                int i = ddlbuildingnames.SelectedIndex + 1;
                SqlCommand cmd = new SqlCommand("insert into placee_tb (PlaceName,Buildingid) values ('" + txtplace.Text + "','" + i + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                ddlbuildingnames.Visible = false;
                btnaddplace.Visible = true;
                btnokplace.Visible = false;
                txtplace.Visible = false;
            }
            else
            {
                lblerror.Text = "Please Enter Place Name";
            }
        }
    }

    public void fillbuilding()
    {
        ddlbuildingnames.DataTextField = "NAME";
        SqlDataAdapter ad = new SqlDataAdapter("select NAME from Building", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);

        ddlbuildingnames.DataSource=dst;
        ddlbuildingnames.DataBind();
    }

}
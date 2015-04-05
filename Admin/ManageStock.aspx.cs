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
using System.Data.SqlClient;

public partial class ManageStock : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        lbluserid.Text = Convert.ToString(Session["adminusername"]);
        if (lbluserid.Text != "")
        {
            if (IsPostBack == false)
            {
                clear();
                fillcategory();
            }
            //clear();
            totalstock();
        }
        else
        {
            Response.Redirect("~/admin/adminlogin.aspx");
        }
    }

    public void clear()
    {
        lblnewstockafteradd.Text = "";
        lblcurrentstock.Text = "";
        txtnewstock.Text = "";
    }
    public void fillcategory()
    {
        SqlDataAdapter ad = new SqlDataAdapter("select catname from tbCategory",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlcategorylist.DataTextField = "catname";
        ddlcategorylist.DataSource = dst;
        ddlcategorylist.DataBind();
    }

    public void fillitemname()
    {
        SqlDataAdapter ad = new SqlDataAdapter("SELECT Item.ItemName FROM Item INNER JOIN tbCategory ON Item.CatID = tbCategory.CatID where tbCategory.catname='"+ddlcategorylist.SelectedItem.Text+"'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlitemlist.DataTextField = "itemname";
        ddlitemlist.DataSource = dst;
        ddlitemlist.DataBind();
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (lblnewstockafteradd.Text != "" && lblcurrentstock.Text != "")
        {
            SqlCommand cmd = new SqlCommand("update item set stock='" + Convert.ToInt16(lblnewstockafteradd.Text) + "' where itemname='" + ddlitemlist.SelectedItem.Text + "'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            clear();
        }
    }
    protected void ddlcategorylist_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillitemname();
    }
    
    protected void ddlitemlist_SelectedIndexChanged1(object sender, EventArgs e)
    {
        SqlDataAdapter ad = new SqlDataAdapter("select stock from item where itemname='" + ddlitemlist.SelectedItem.Text + "'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        lblcurrentstock.Text = dst.Tables[0].Rows[0][0].ToString();
        totalstock();
    }

    public void totalstock()
    {
        if (lblcurrentstock.Text != "" && txtnewstock.Text !="")
        {
            int current = Convert.ToInt16(lblcurrentstock.Text);
            int add = Convert.ToInt16(txtnewstock.Text);
            int total = current + add;
            lblnewstockafteradd.Text =Convert.ToString(total);
        }
    }
}
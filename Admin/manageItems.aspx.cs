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
using System.Data.SqlClient;

public partial class Admin_manageItems : System.Web.UI.Page
{
    string con;
    datacollect datacoll;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        con = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        datacoll = new datacollect(con);
        if (IsPostBack == false)
        {
            hide();
            ddlfill();
            btnshowitemstable.Visible = false;
            btnaddcat.Visible = false;
            
        }
        lblerror.Text = "";
    }
    public void clear()
    {
        txtitemname.Text = "";
        txtitemprice.Text = "";
    }
    public void hide()
    {
        ddlitemtype.Visible = false;
        txtitemname.Visible = false;
        txtitemprice.Visible = false;
        btnadditem.Visible = false;
        lblcattype.Visible = false;
        lblitems.Visible = false;
        lblprice.Visible = false;
        btnhideitemlist.Visible = false;
    }
    public void show()
    {
        ddlitemtype.Visible = true;
        txtitemname.Visible = true;
        txtitemprice.Visible = true;
        btnadditem.Visible = true;
        lblcattype.Visible = true;
        lblitems.Visible = true;
        lblprice.Visible = true;
    }
    public void ddlfill()
    {
        SqlDataAdapter ad = new SqlDataAdapter("Select catname from tbcategory",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlitemtype.DataTextField = "catname";
        ddlitemtype.DataSource = dst;
        ddlitemtype.DataBind();
    }
    protected void btnaddnewitem_Click(object sender, EventArgs e)
    {
        show();
        btnaddnewitem.Visible = false;
        grvitemlist.Visible = false;
        btnhideitemlist.Visible = false;
        btnshowitemstable.Visible = true;
        btncategory.Visible = false;
        btnaddcat.Visible = false;
    }
    protected void btnadditem_Click(object sender, EventArgs e)
    {
        btnaddnewitem.Visible = true;
        hide();
        btnshowitemstable.Visible = false;
        btnhideitemlist.Visible = true;
        if (txtitemprice.Text != "" || txtitemprice.Text != "")
        {
            int v=0;
            SqlDataAdapter ad = new SqlDataAdapter("Select itemname from item",cn);
            DataSet dst = new DataSet();
            ad.Fill(dst);
            string itmname="";
            for (int i = 0; i < dst.Tables[0].Rows.Count;i++)
            {
                string item=dst.Tables[0].Rows[i][0].ToString();
                if (item == txtitemname.Text)
                {
                    lblerror.Text = "Item Already Exist!!";
                    itmname = "";
                    break;
                }
                else
                {
                    itmname = dst.Tables[0].Rows[i][0].ToString();
                }
               // break;
            }
            if (itmname != "")
            {
                v = ddlitemtype.SelectedIndex;
                SqlCommand cmd = new SqlCommand("insert into item (itemname,catid,price,stock) values ('" + txtitemname.Text + "','" + (v + 1) + "','" + Convert.ToInt16(txtitemprice.Text) + "','" + 0 + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                lblerror.Text = "success Fully Add";
            }
            
            
        }
        else
        {
            lblerror.Text="Please Enter ItemName And Price";
        }
        clear();
        btnhideitemlist.Visible = false;
        btncategory.Visible = true;
    }
    protected void fillitems()
    {
        DataSet dst = new DataSet();
        dst = datacoll.select_itmes();
        grvitemlist.DataSource = dst;
        grvitemlist.DataBind();
    }
    protected void btnshowitemstable_Click1(object sender, EventArgs e)
    {
        hide();
        fillitems();
        grvitemlist.Visible = true;
        btnaddnewitem.Visible = true;
        btnshowitemstable.Visible = false;
        btnhideitemlist.Visible = true;
        btncategory.Visible = true;
        
    }
    protected void grvitemlist_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int v;
        v = e.RowIndex;
        string st1, st2, st3, st4, st5, st6;
        st1 = ((TextBox)grvitemlist.Rows[v].Cells[2].Controls[0]).Text;
        st2 = ((TextBox)grvitemlist.Rows[v].Cells[3].Controls[0]).Text;
        st3 = ((TextBox)grvitemlist.Rows[v].Cells[4].Controls[0]).Text;
        st4 = ((TextBox)grvitemlist.Rows[v].Cells[5].Controls[0]).Text;
        st5 = ((TextBox)grvitemlist.Rows[v].Cells[6].Controls[0]).Text;
        st6 = ((TextBox)grvitemlist.Rows[v].Cells[7].Controls[0]).Text;

        datacoll.update_items(st2, st3, st4, st5, st6, st1);
        grvitemlist.EditIndex = -1;
        fillitems();
    }
    protected void grvitemlist_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvitemlist.EditIndex = -1;
        fillitems();
    }
    protected void grvitemlist_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int i;
        i = e.RowIndex;
        string delete = grvitemlist.Rows[i].Cells[2].Text;
        datacoll.delete_items(delete);
        fillitems();
    }
    protected void grvitemlist_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvitemlist.EditIndex = e.NewEditIndex;
        fillitems();
    }
    protected void btnhideitemlist_Click(object sender, EventArgs e)
    {
        btnshowitemstable.Visible = true;
        grvitemlist.Visible = false;
        btnhideitemlist.Visible = false;
        btncategory.Visible = true;
    }
    protected void btncategory_Click(object sender, EventArgs e)
    {

        btnshowitemstable.Visible = false;
        btnhideitemlist.Visible = false;
        lblcattype.Visible = false;
        lblitems.Visible = false;
        lblprice.Visible = false;
        ddlitemtype.Visible = false;
        txtitemname.Visible = true;
        txtitemprice.Visible = false;
        btnadditem.Visible = false;
        btnaddnewitem.Visible = true;
        btnaddcat.Visible = true;
        grvitemlist.Visible = false;
    }
    protected void btnaddcat_Click(object sender, EventArgs e)
    {
        SqlDataAdapter ad=new SqlDataAdapter("select catname from tbcategory",cn);
        DataSet dst=new DataSet();
        ad.Fill(dst);
        string category = "";
        for(int i=0;i<dst.Tables[0].Rows.Count;i++)
        {
            string cat = dst.Tables[0].Rows[i][0].ToString();
            if (cat == txtitemname.Text)
            {
                lblerror.Text = "Item Already Exist!!";
                category = "";
                break;
            }
            else
            {
                category = dst.Tables[0].Rows[i][0].ToString();
            }
        }

        if (txtitemname.Text != "")
        {
            if (category != "")
            {
                SqlCommand cmd = new SqlCommand("insert into tbcategory (catname) values ('" + txtitemname.Text + "') ", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                txtitemname.Visible = false;
                btnaddcat.Visible = false;
                txtitemname.Text = "";
            }
            else
            {
                lblerror.Text = "Category Name Already Exist!!!";
                txtitemname.Text = "";
            }
       }
        else
        {
            lblerror.Text = "Please Enter Category Name";
            txtitemname.Text = "";
        }
        
    }
}

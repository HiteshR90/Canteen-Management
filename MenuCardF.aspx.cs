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
using System.Data.SqlClient;

public partial class MenuCardF : System.Web.UI.Page
{
    datacollect datacoll;
    string con, username;

    int userid, qty, price;
    string itemname;

    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        username = Convert.ToString(Session["username"]);
        lbluser.Text = username;

        //geting userid
        SqlCommand cmd = new SqlCommand("select userid from customerdata where username='" + username + "'", cn);
        cn.Open();
        SqlDataReader dar = cmd.ExecuteReader();
        while (dar.Read())
        {
            userid = Convert.ToInt16(dar["userid"]);
        }
        cn.Close();

        
        if (IsPostBack == false)
        {
            fillselecttype();
            //clear();
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

    public void fillselecttype()
    {
        SqlDataAdapter ad = new SqlDataAdapter("select catname from tbcategory",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlselectcattype.DataTextField = "catname";
        ddlselectcattype.DataSource = dst;
        ddlselectcattype.DataBind();
    }
    protected void ddlselectcattype_SelectedIndexChanged(object sender, EventArgs e)
    {
        change();
    }

    public void change()
    {
        int catid = ddlselectcattype.SelectedIndex;
        if (lbluser.Text == "")
        {
            grvdatatable.Columns[0].Visible = false;
        }

        SqlDataAdapter ad = new SqlDataAdapter("SELECT Item.ItemName, Item.Price FROM Item INNER JOIN tbCategory ON Item.CatID = tbCategory.CatID where tbCategory.CatID='" + (catid + 1) + "' AND item.stock>0", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        grvdatatable.DataSource = dst;
        grvdatatable.DataBind();
            //DataSet dst = new DataSet();
            //dst = datacoll.select_items_cattype(cattype);
            //grvdatatable.DataSource = dst;
            //grvdatatable.DataBind();
       
    }
    protected void grvdatatable_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        //itemid
        itemname = grvdatatable.SelectedRow.Cells[1].Text;
        

        //price
        price =Convert.ToInt16(grvdatatable.SelectedRow.Cells[2].Text);
       

        //qty
        //DropDownList t =(DropDownList) grvdatatable.SelectedRow.FindControl("ddlqty");
        //string st = t.SelectedValue;
        //qty = Convert.ToInt16(st);
        qty = 1;
        //SqlCommand cmd1 = new SqlCommand("insert into OrderTemp (userid,itemname,qty,price) values ('" + userid + "','" + itemname + "','" + qty + "','" + price + "')", cn);
        //cn.Open();
        //cmd1.ExecuteNonQuery();
        //cn.Close();

        SqlDataAdapter ad = new SqlDataAdapter("select itemname from ordertemp where userid='" + userid + "'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        if (dst.Tables[0].Rows.Count == 0)
        {
            datacoll.insert_item_temp_order(userid, itemname, qty, price);
        }
        else
        {
            string itm = "";
            for (int i = 0; i < dst.Tables[0].Rows.Count; i++)
            {
                
                string item = dst.Tables[0].Rows[i][0].ToString();
                if (itemname == item)
                {
                    itm = "";
                    break;
                }
                else
                {
                    itm = "som";                    
                }
               
            }
            if (itm != "")
            {
                datacoll.insert_item_temp_order(userid, itemname, qty, price);
            }
        }
            
    }


    protected void btnok_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/menucardf1.aspx");
    }


    protected void btncancle_Click(object sender, EventArgs e)
    {
        clear();
    }

    public void clear()
    {
        SqlCommand cmd = new SqlCommand("delete from ordertemp where userid='" + userid + "'", cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
}
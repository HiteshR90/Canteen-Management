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

public partial class Admin_Managesusers : System.Web.UI.Page
{
    string con;
    datacollect datacoll;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        datacoll = new datacollect(con);
    }
    protected void btnseeuser_Click(object sender, EventArgs e)
    {
        filldata();
    }
    protected void filldata()
    {
        DataSet dst = new DataSet();
        dst = datacoll.select_users();
        grvuserdata.DataSource = dst.Tables[0];
        grvuserdata.DataBind();

    }
    protected void grvuserdata_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grvuserdata.EditIndex = e.NewEditIndex;
        filldata();
    }
    protected void grvuserdata_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int v;
        v = e.RowIndex;
        string st1, st2, st3, st4, st5, st6,st7,st8,st9,st10;
        st1 = ((TextBox)grvuserdata.Rows[v].Cells[2].Controls[0]).Text;
        st2=((TextBox)grvuserdata.Rows[v].Cells[3].Controls[0]).Text;
        st3=((TextBox)grvuserdata.Rows[v].Cells[4].Controls[0]).Text;
        st4=((TextBox)grvuserdata.Rows[v].Cells[5].Controls[0]).Text;
        st5=((TextBox)grvuserdata.Rows[v].Cells[6].Controls[0]).Text;
        st6 = ((TextBox)grvuserdata.Rows[v].Cells[7].Controls[0]).Text;
        st7=((TextBox)grvuserdata.Rows[v].Cells[8].Controls[0]).Text;
        st8=((TextBox)grvuserdata.Rows[v].Cells[9].Controls[0]).Text;
        st9=((TextBox)grvuserdata.Rows[v].Cells[10].Controls[0]).Text;
        st10 = ((TextBox)grvuserdata.Rows[v].Cells[11].Controls[0]).Text;

        datacoll.update_user_data(st2, st3, st4, st5, st6, st7, st8, st9, st10, st1);
        grvuserdata.EditIndex = -1;
        filldata();
    }
    protected void grvuserdata_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grvuserdata.EditIndex = -1;
        filldata();
    }
    protected void grvuserdata_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int i;
        i = e.RowIndex;
        string delete=grvuserdata.Rows[i].Cells[2].Text;
        datacoll.delete_user(delete);
        filldata();
    }
    
}

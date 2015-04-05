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

public partial class MenucardF1 : System.Web.UI.Page
{
    datacollect datacoll;
    string con, username,emailid,phoneno;
    int userid;
    long total=0;

    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        username = Convert.ToString(Session["username"]);
        lbluser.Text = username;

        if (lbluser.Text != "")
        {


            //geting userid
            SqlCommand cmd = new SqlCommand("select userid,emailid,phoneno from customerdata where username='" + username + "'", cn);
            cn.Open();
            SqlDataReader dar = cmd.ExecuteReader();
            while (dar.Read())
            {
                userid = Convert.ToInt16(dar["userid"]);
                emailid = Convert.ToString(dar["emailid"]);
                phoneno = Convert.ToString(dar["phoneno"]);
            }
            cn.Close();

            if (IsPostBack == false)
            {

                fill();
                insert_ddlselect();
                //totalreturn();
                
               // cancle();
            }
            
                
                totalreturn();
                stock();
                
                lblerror.Text = "";
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
        else
        {
            Response.Redirect("home.aspx");
        }
    }

    public void stock()
    {
        int qty=0;
        string item="";
       lblstock.Text="";
        for (int i = 0; i < grvfinal.Rows.Count; i++)
        {
            
            TextBox t = (TextBox)grvfinal.Rows[i].FindControl("txtqty"); 
            Label litemname = (Label)grvfinal.Rows[i].FindControl("lblitemname");
            item=litemname.Text;
            qty = Convert.ToInt16(t.Text);
            SqlDataAdapter ad = new SqlDataAdapter("select stock from item where itemname='"+item+"'",cn);
            DataSet dst = new DataSet();
            ad.Fill(dst);
            int aa=Convert.ToInt16(dst.Tables[0].Rows[0][0].ToString());
            if (aa < qty)
            {
                lblstock.Text += " stock available of "+ item+" is only "+aa;
            }
            
        }
        
    }

    public void fill()
    {
       
        SqlDataAdapter ad = new SqlDataAdapter("select itemname,price from ordertemp where userid='"+userid+"'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        grvfinal.DataSource = dst;
        grvfinal.DataBind();
    }

    public void cancle()
    {
        SqlCommand cmd = new SqlCommand("delete from ordertemp where userid='" + userid + "'", cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    protected void btnfinish_Click(object sender, EventArgs e)
    {
        
        
        if (lblstock.Text == "")
        { 
            int qty=0;
            string item="";
            for (int i = 0; i < grvfinal.Rows.Count; i++)
            {
            int stock=0;
            TextBox t = (TextBox)grvfinal.Rows[i].FindControl("txtqty"); 
            Label litemname = (Label)grvfinal.Rows[i].FindControl("lblitemname");
            item=litemname.Text;
            qty = Convert.ToInt16(t.Text);

            SqlDataAdapter ad = new SqlDataAdapter("select stock from item where itemname='"+item+"'",cn);
            DataSet dst = new DataSet();
            ad.Fill(dst);
            int aa=Convert.ToInt16(dst.Tables[0].Rows[0][0].ToString());

            stock = aa - qty;
            SqlCommand cmd = new SqlCommand("update item set Stock='" + Convert.ToInt16(stock) + "' where itemname='"+item+"'", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            }
            
            fillfinal_data();
            
            stockerror.Text = "";
            if (lblerror.Text == "")
            {
                cancle();
                Response.Redirect("menucardf.aspx");
            }
        }
        else
        {
            stockerror.Text = "Make Change In Quantity";
        }
    }


    public void fillfinal_data()
    {
        string itemname, qty, price,placemain,placesub,place;
        long amount,balance;
        if (ddlplacemain.SelectedValue == "Select" )
        {

        }
        else
        {
            placemain = ddlplacemain.SelectedValue;
            placesub= ddlplacesub.SelectedValue;
            place = placemain+"+" + placesub;
            String date = Convert.ToString(string.Format("{0:dd/MM/yyyy}", datacoll.add_date_time()));
            String time = Convert.ToString(string.Format("{0:T}",datacoll.add_date_time()));
            for (int i = 0; i < grvfinal.Rows.Count; i++)
            {
                TextBox t = (TextBox)grvfinal.Rows[i].FindControl("txtqty");
                Label litemname = (Label)grvfinal.Rows[i].FindControl("lblitemname");
                Label lprice = (Label)grvfinal.Rows[i].FindControl("lblprice");
                Label ltotal = (Label)grvfinal.Rows[i].FindControl("lbltotalp");

                //itemname = grvfinal.Rows[i].Cells[2].Text;
                ////qty = grvfinal.Rows[i].Cells[1].Text;
                //price = grvfinal.Rows[i].Cells[3].Text;

                itemname = litemname.Text;
                price = lprice.Text;
                qty = t.Text;

                amount = Convert.ToInt64(qty) * Convert.ToInt64(price);

                //Response.Write(amount);
                SqlCommand cmdbal = new SqlCommand("select balance from transection where userid='" + userid + "' order by tid desc", cn);
                
                cn.Open();
                balance=Convert.ToInt16(cmdbal.ExecuteScalar());
                //Response.Write(balance);
                cn.Close();

                
                if (placesub!="Select" || placesub=="")
                {
                    if (itemname!="")
                    {
                        if (amount <= balance)
                        {
                            lblerror.Text = "";
                            
                            SqlCommand cmd = new SqlCommand("insert into order_tb (userid,itemname,qty,price,place,orderdate,ordertime) values ('" + userid + "','" + itemname + "','" + Convert.ToInt16(qty) + "','" + Convert.ToInt16(price) + "','" + place + "','" + date + "','" + time + "') ", cn);
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            //datacoll.insert_item_order(userid, itemname, Convert.ToInt16(qty), Convert.ToInt16(price),place,date,time);
                            //datacoll.add_date_time();


                            total += amount;
                            
                            balance = balance - amount;
                            //Response.Write(balance);
                          //  datacoll.sendmail(emailid, "Transection", "Your Balance is==>" + balance + " you bye an items of==>" + amount);
                          //  datacoll.sendSMS(phoneno, "Transection==>"+ "Your Balance is==>" + balance + " you bye an items of==>" + amount);

                            

                           
                            
                            //Label tid;

                            //SqlDataAdapter ad = new SqlDataAdapter("select tid from transection where userid='"+userid+"' AND date='"+date+"' time='"+time+"'",cn);
                            //DataSet dst = new DataSet();
                            //ad.Fill(dst);
                            //tid.Text = dst.Tables[0].Rows[0][0].ToString();


                            

                            Label orderid=new Label();
                            orderid.Text = "";
                            SqlDataAdapter ad = new SqlDataAdapter("select orderid from order_tb where userid='" + Convert.ToInt16(userid) + "' AND orderdate='" + date + "' AND ordertime='" + time + "' ORDER BY orderid DESC", cn);
                            DataSet dst = new DataSet();
                            ad.Fill(dst);
                            orderid.Text = dst.Tables[0].Rows[0][0].ToString();


                            

                            SqlCommand cmdtr = new SqlCommand("insert into transection (Userid,Date,Time,Amount,Balance,orderid) values ('" + userid + "','" + date + "','" + time + "','" + amount + "','" + balance + "','"+orderid.Text+"')", cn);
                            cn.Open();
                            cmdtr.ExecuteNonQuery();
                            cn.Close();

                            Label tid = new Label();
                            tid.Text = "";
                            SqlDataAdapter adt = new SqlDataAdapter("select tid from transection where userid='" + Convert.ToInt16(userid) + "' AND date='" + date + "'  ORDER BY tid DESC", cn);
                            DataSet dstt = new DataSet();
                            adt.Fill(dstt);
                            tid.Text = dstt.Tables[0].Rows[0][0].ToString();


                            SqlCommand cmdorder = new SqlCommand("insert into order_manages_temp (orderid,tid,username,itemname,Price,Qty,Place,date,time,total,balance) values ('" + orderid.Text + "','"+Convert.ToInt16(tid.Text)+"','" + username + "','" + itemname + "','" + price + "','" + qty + "','" + place + "','" + date + "','" + time + "','" + amount + "','" + balance + "')", cn);
                            cn.Open();
                            cmdorder.ExecuteNonQuery();
                            cn.Close();

                            btnfinish.Visible = false;
                            grvfinal.Visible = false;
                            ddlplacesub.Visible = false;
                            ddlplacemain.Visible = false;
                            

                        }

                        else
                        {
                            lblerror.Text="your balance is lower so u cant make transection";
                            
                        }
                        lbltotal.Text = Convert.ToString(total);

                    }
                    else
                    {
                        lblerror.Text="You Not Select Any Items";
                    }
                }
                else
                {
                    lblerror.Text = "Please Slect Place for order";
                }
               
            }
            

            
        }


    }

    public void totalreturn()
    {
        total = 0;
        int price=0, qty=0,tot=0;
        for (int i = 0; i < grvfinal.Rows.Count; i++)
        {
            TextBox t = (TextBox)grvfinal.Rows[i].FindControl("txtqty");
            
            //Label litemname = (Label)grvfinal.Rows[i].FindControl("lblitemname");
            Label lprice = (Label)grvfinal.Rows[i].FindControl("lblprice");
            Label ltotal = (Label)grvfinal.Rows[i].FindControl("lbltotalp");

            price =Convert.ToInt16(lprice.Text);
            qty = Convert.ToInt16(t.Text);
            tot = (price * qty);
            ltotal.Text = Convert.ToString(tot);
            total += tot;
        }
        lbltotal.Text = Convert.ToString(total);
    }

    public void insert_ddlselect()
    {
        ddlplacemain.DataTextField = "name";
        SqlDataAdapter ad = new SqlDataAdapter("select name from Building",cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlplacemain.DataSource = dst;
        ddlplacemain.DataBind();
    }

    public void insert_ddlbuild_sub()
    {
        int i = ddlplacemain.SelectedIndex + 1;
        ddlplacesub.DataTextField = "placename";
        SqlDataAdapter ad = new SqlDataAdapter("select  placename from placee_tb where buildingid='"+i+"'", cn);
        DataSet dst = new DataSet();
        ad.Fill(dst);
        ddlplacesub.DataSource = dst;
        ddlplacesub.DataBind();
    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        cancle();
        fill();
    }

    protected void grvfinal_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int i;
        i = e.RowIndex;

        //grvfinal.DeleteRow(i);
        //grvfinal.EditIndex = -1;


        //int i = int.Parse(grvfinal.Rows[e.RowIndex].Cells[0].Text);
        //grvfinal.EditIndex = -1;

        //grvfinal.DataBind();

        //TextBox t = (TextBox)grvfinal.Rows[i].FindControl("txtqty");
        //Response.Write(i);

        Label litemname = (Label)grvfinal.Rows[i].FindControl("lblitemname");

        string name = litemname.Text;
        string qty = grvfinal.Rows[i].Cells[3].Text;
        //datacoll.delete_temp_items(name,Convert.ToInt16(qty));
        SqlCommand cmd = new SqlCommand("delete from ordertemp where itemname='"+name+"' AND userid='"+userid+"'",cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
        
        fill();
        totalreturn();
    }
   

    protected void ddlplacemain_SelectedIndexChanged1(object sender, EventArgs e)
    {
        insert_ddlbuild_sub();
    }
    protected void btnback_Click(object sender, EventArgs e)
    {

        Response.Redirect("menucardf.aspx");
    }
}
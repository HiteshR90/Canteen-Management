using System;
using System.Data;
using System.Configuration;
//using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.IO;



namespace cnteeenbind
{
    public class datacollect
    {
        SqlConnection cn;
        public datacollect(String con)
        {
            cn = new SqlConnection(con);
        }

        public datacollect()
        { 
            
        }
        /* Log In Page Data */

        public int change_password(string username,string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_change_password", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 50));
                cmd.Parameters["@username"].Value = username;

                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 50));
                cmd.Parameters["@password"].Value = password;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }

                
        }
        
        public DataSet password_check(string username)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_login_validation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 50));
                cmd.Parameters["@username"].Value = username;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                DataSet dst = new DataSet();
                cn.Open();
                ad.Fill(dst, "customerdata");
                cn.Close();
                return dst;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        
        public DataSet login_check_available(string username, string emailid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_login_validation",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@username",SqlDbType.NVarChar, 50));
                cmd.Parameters["@username"].Value = username;

                cmd.Parameters.Add(new SqlParameter("@emailid", SqlDbType.NVarChar, 50));
                cmd.Parameters["@emailid"].Value = emailid;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                DataSet dst = new DataSet();
                cn.Open();
                ad.Fill(dst, "customerdata");
                cn.Close();
                return dst;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataSet login(string username, string emailid, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_login",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@username",SqlDbType.NVarChar, 50));
                cmd.Parameters["@username"].Value = username;

                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 50));
                cmd.Parameters["@password"].Value = password;

                cmd.Parameters.Add(new SqlParameter("@emailid", SqlDbType.NVarChar, 50));
                cmd.Parameters["@emailid"].Value = emailid;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                DataSet dst = new DataSet();
                cn.Open();
                ad.Fill(dst, "customerdata");
                cn.Close();
                return dst;
            }
            catch (Exception e)
            {
                return null;
            }          
            
        }

        public int register(string FName, string Lname, string UserName, string EmailID, string Password, string UserType, string Branch, string Semester, string Phoneno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Insert_customer", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@FName", SqlDbType.NVarChar, 50));
                cmd.Parameters["@FName"].Value = FName;

                cmd.Parameters.Add(new SqlParameter("@Lname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Lname"].Value = Lname;

                cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 15));
                cmd.Parameters["@UserName"].Value = UserName;

                cmd.Parameters.Add(new SqlParameter("@EmailID", SqlDbType.NVarChar, 50));
                cmd.Parameters["@EmailID"].Value = EmailID;


                cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Password"].Value = Password;

                cmd.Parameters.Add(new SqlParameter("@UserType", SqlDbType.NVarChar, 50));
                cmd.Parameters["@UserType"].Value = UserType;

                cmd.Parameters.Add(new SqlParameter("@Branch", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Branch"].Value = Branch;

                cmd.Parameters.Add(new SqlParameter("@Semester", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Semester"].Value = Semester;

                cmd.Parameters.Add(new SqlParameter("@Phoneno", SqlDbType.NVarChar, 50));
                cmd.Parameters["@Phoneno"].Value = Phoneno;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }


        /*Menu Card Data*/
        public DataSet select_items_cattype(string cattype)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_select_items", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@cattype", SqlDbType.NVarChar, 50));
                cmd.Parameters["@cattype"].Value = cattype;

                
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                DataSet dst = new DataSet();
                cn.Open();
                ad.Fill(dst, "item");
                cn.Close();
                return dst;
            }
            catch (Exception e)
            {
                return null;
            }
        }

       
        public int insert_item_temp_order(int userid, String itemname, int qty, int price)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insert_item_temp", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.Int, 50));
                cmd.Parameters["@userid"].Value = userid;

                cmd.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemname"].Value = itemname;

                cmd.Parameters.Add(new SqlParameter("@qty", SqlDbType.Int, 15));
                cmd.Parameters["@qty"].Value = qty;

                cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Int, 50));
                cmd.Parameters["@price"].Value = price;       

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }


        public int insert_item_order(int userid, String itemname, int qty, int price, string place, string date, string time)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insert_item_order", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@userid", SqlDbType.Int, 50));
                cmd.Parameters["@userid"].Value = userid;

                cmd.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemname"].Value = itemname;

                cmd.Parameters.Add(new SqlParameter("@qty", SqlDbType.Int, 15));
                cmd.Parameters["@qty"].Value = qty;

                cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Int, 50));
                cmd.Parameters["@price"].Value = price;

                cmd.Parameters.Add(new SqlParameter("@place", SqlDbType.NVarChar, 50));
                cmd.Parameters["@place"].Value = place;

                cmd.Parameters.Add(new SqlParameter("@orderdate", SqlDbType.NVarChar, 50));
                cmd.Parameters["@orderdate"].Value = date;

                cmd.Parameters.Add(new SqlParameter("@ordertime", SqlDbType.NVarChar, 50));
                cmd.Parameters["@ordertime"].Value = time; 

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public int delete_temp_items(string itemname,int qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_temp_item", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemname"].Value = itemname;

                cmd.Parameters.Add(new SqlParameter("@qty", SqlDbType.NVarChar, 50));
                cmd.Parameters["@qty"].Value = qty;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /*SET date time */
        public DateTime add_date_time()
        {
           // try
            {
                SqlCommand cmd = new SqlCommand("date_time", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

               
                
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                DateTime cnt = (DateTime)cmd.ExecuteScalar();

                cn.Close();
                return cnt;
            }
           // catch (Exception ex)
            {
               // return 0;
            }


        }


        /*Admin Data*/

        /*Admin Manage Items Data*/

        public int add_new_items(string itemname, string itemcattype, string itemprice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insert_items", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemname"].Value = itemname;

                cmd.Parameters.Add(new SqlParameter("@itemcattype", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemcattype"].Value = itemcattype;

                cmd.Parameters.Add(new SqlParameter("@itemprice", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemprice"].Value = itemprice;
                
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }
        
        public DataSet select_itmes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_select_item_list", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);


                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                DataSet dst = new DataSet();
                cn.Open();
                ad.Fill(dst, "item");
                cn.Close();
                return dst;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        
        public int update_items(string itemname, string itemcattype, string itemprice, string itemavailabletime, string itemremark, string itemid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_update_items", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@itemname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemname"].Value = itemname;

                cmd.Parameters.Add(new SqlParameter("@itemcattype", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemcattype"].Value = itemcattype;

                cmd.Parameters.Add(new SqlParameter("@itemprice", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemprice"].Value = itemprice;

                cmd.Parameters.Add(new SqlParameter("@itemavailabletime", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemavailabletime"].Value = itemavailabletime;

                cmd.Parameters.Add(new SqlParameter("@itemremark", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemremark"].Value = itemremark;

                cmd.Parameters.Add(new SqlParameter("@itemid", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemid"].Value = itemid;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }
        
        public int delete_items(string itemid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_items", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@itemid", SqlDbType.NVarChar, 50));
                cmd.Parameters["@itemid"].Value = itemid;


                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }




        /*Admin Manage User Data*/

        public DataSet select_users()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_select_users", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);


                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                DataSet dst = new DataSet();
                cn.Open();
                ad.Fill(dst, "customerdata");
                cn.Close();
                return dst;
            }
            catch (Exception e)
            {
                return null;
            }
        }
                
        public int update_user_data(string fname, string lname, string username, string emailid, string password, string usertype, string branch, string semester, string phoneno, string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_update_user", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@fname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@fname"].Value = fname;

                cmd.Parameters.Add(new SqlParameter("@lname", SqlDbType.NVarChar, 50));
                cmd.Parameters["@lname"].Value = lname;

                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 50));
                cmd.Parameters["@username"].Value = username;

                cmd.Parameters.Add(new SqlParameter("@emailid", SqlDbType.NVarChar, 50));
                cmd.Parameters["@emailid"].Value = emailid;

                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 50));
                cmd.Parameters["@password"].Value = password;

                cmd.Parameters.Add(new SqlParameter("@usertype", SqlDbType.NVarChar, 50));
                cmd.Parameters["@usertype"].Value = usertype;

                cmd.Parameters.Add(new SqlParameter("@branch", SqlDbType.NVarChar, 50));
                cmd.Parameters["@branch"].Value = branch;

                cmd.Parameters.Add(new SqlParameter("@semester", SqlDbType.NVarChar, 50));
                cmd.Parameters["@semester"].Value = semester;

                cmd.Parameters.Add(new SqlParameter("@phoneno", SqlDbType.NVarChar, 50));
                cmd.Parameters["@phoneno"].Value = phoneno;

                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 50));
                cmd.Parameters["@id"].Value = id;

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }
        
        public int delete_user(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_delete_user", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);

                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 50));
                cmd.Parameters["@id"].Value = id;


                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
                int cnt = cmd.ExecuteNonQuery();

                cn.Close();
                return cnt;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }


        //sending emill
        public void sendmail(string receivermailiid, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("billu.ramoliya@gmail.com");
            mail.To.Add(new MailAddress(receivermailiid));

            mail.Subject = subject;
            mail.Body = body;

            SmtpClient cl = new SmtpClient();
            cl.Host = "smtp.gmail.com";

            cl.Credentials = new NetworkCredential("billu.ramoliya@gmail.com", "asdfgASDFG");
            cl.EnableSsl = true;

            try
            {
                cl.Send(mail);
            }
            catch (Exception ex)
            {
                
            }

        }

        //sendIng SMS

        public void sendSMS(String receiver, string message)
        {
            string uid, password;
            uid = "9909540022";
            password = "ashvin04";
            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://ubaid.tk/sms/sms.aspx?uid=" + uid + "&pwd=" + password + "&msg=" + message + "&phone=" + receiver + "&provider=way2sms");

            HttpWebResponse myResp = (HttpWebResponse)req.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
        }

        //select username
        public DataSet select_username(string username)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_select_username", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);


                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                    DataSet dst = new DataSet();
                    cn.Open();
                    ad.Fill(dst, "customerdata");
                    cn.Close();
                    return dst;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

    }

   

     

}
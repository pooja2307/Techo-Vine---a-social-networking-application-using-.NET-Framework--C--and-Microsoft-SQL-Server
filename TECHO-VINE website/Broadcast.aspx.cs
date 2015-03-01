using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Broadcast : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       /* string fname, lname, eid;
        SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
         SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand("Select lastname from signup where emailid = '" + Session["email"] + "'", con1);
           // SqlCommand cmd = new SqlCommand("Select firstname from signup where emailid = '" + Login1.UserName + "'", con1);
            con1.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
           
       
                Session["lastname"] = Convert.ToString(ds.Tables[0].Rows[0]["lastname"]);
           


           //Session["Name"] = cmd.ExecuteScalar();

            
            con1.Close();
         */           
        
        
        
       string post = TextBox1.Text;
       int user= Convert.ToInt32(Session["uid"]);

            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
           
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO broadcast(uid,post) values (@uid,@post)", con);
                

                cmd.CommandType = CommandType.Text;

              
               cmd.Parameters.AddWithValue("@uid", user); //cmd.Parameters.AddWithValue("@U_ID", );
               cmd.Parameters.AddWithValue("@post", post); //cmd.Parameters.AddWithValue("@U_ID", );
              
                cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                
                con.Close();


                


            }
             
                            catch (Exception exc)
                            {
                            }
            

            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
            con1.Open();

            string broadcasttouser = "select uid from signup where type= 'Faculty'";
        SqlCommand command = new SqlCommand(broadcasttouser, con1);

            SqlDataReader dr = command.ExecuteReader();
        string texts= TextBox1.Text;

            while (dr.Read())
            {
                SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
                con2.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
             
                adapter.SelectCommand = new SqlCommand("Select postid from broadcast where post = '" + texts + "'", con2);
                try
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    int pid = Convert.ToInt32(ds.Tables[0].Rows[0]["postid"]);

                    SqlCommand cmd1 = new SqlCommand("INSERT INTO relate(uid,pid) values (@uid,@postid)", con2);

                    cmd1.CommandType = CommandType.Text;
         

                    cmd1.Parameters.AddWithValue("@uid", dr[0]); //cmd.Parameters.AddWithValue("@U_ID", );
                    cmd1.Parameters.AddWithValue("@postid", pid); //cmd.Parameters.AddWithValue("@U_ID", );
                    //    Response.Write(pid);
                    //     cmd1.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                    //    cmd1.Parameters["@ERROR"].Direction = ParameterDirection.Output;

                    cmd1.ExecuteNonQuery();
                    con2.Close();
                  
                }
                catch (Exception exe)
                {
                    Response.Write(exe.Message);
                    con2.Close();
                }
            }


            con1.Close();
            Response.Redirect("acc1.aspx");
    

                 
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string post = TextBox1.Text;
        int user = Convert.ToInt32(Session["uid"]);

        SqlConnection con3 = new SqlConnection();

        con3.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

        con3.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO broadcast(uid,post) values (@uid,@post)", con3);


            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@uid", user); //cmd.Parameters.AddWithValue("@U_ID", );
            cmd.Parameters.AddWithValue("@post", post); //cmd.Parameters.AddWithValue("@U_ID", );

            cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
            cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();


            con3.Close();





        }

        catch (Exception exc)
        {
        }


        SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
        con4.Open();

        string broadcasttouser1 = "select uid from signup where type= 'Student'";
        SqlCommand command1 = new SqlCommand(broadcasttouser1, con4);

        SqlDataReader dr1 = command1.ExecuteReader();
        string texts1 = TextBox1.Text;

        while (dr1.Read())
        {
            SqlConnection con5 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
            con5.Open();

            SqlDataAdapter adapter1 = new SqlDataAdapter();

            adapter1.SelectCommand = new SqlCommand("Select postid from broadcast where post = '" + texts1 + "'", con5);
            try
            {
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1);
                int pid = Convert.ToInt32(ds1.Tables[0].Rows[0]["postid"]);

                SqlCommand cmd1 = new SqlCommand("INSERT INTO relate(uid,pid) values (@uid,@postid)", con5);

                cmd1.CommandType = CommandType.Text;


                cmd1.Parameters.AddWithValue("@uid", dr1[0]); //cmd.Parameters.AddWithValue("@U_ID", );
                cmd1.Parameters.AddWithValue("@postid", pid); //cmd.Parameters.AddWithValue("@U_ID", );
                //    Response.Write(pid);
                //     cmd1.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                //    cmd1.Parameters["@ERROR"].Direction = ParameterDirection.Output;

                cmd1.ExecuteNonQuery();
                con5.Close();

            }
            catch (Exception exe)
            {
                Response.Write(exe.Message);
                con5.Close();
            }
        }


        con4.Close();
        Response.Redirect("acc1.aspx");
    

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string post = TextBox1.Text;
        int user = Convert.ToInt32(Session["uid"]);

        SqlConnection con6 = new SqlConnection();

        con6.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

        con6.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO broadcast(uid,post) values (@uid,@post)", con6);


            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@uid", user); //cmd.Parameters.AddWithValue("@U_ID", );
            cmd.Parameters.AddWithValue("@post", post); //cmd.Parameters.AddWithValue("@U_ID", );

            cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
            cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();


            con6.Close();





        }

        catch (Exception exc)
        {
        }


        SqlConnection con7 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
        con7.Open();


        string dept10 = Convert.ToString(Session["dept"]);
           
        string broadcasttouser2 = "select uid from signup where dept = '" + dept10 + "'";
        SqlCommand command2 = new SqlCommand(broadcasttouser2, con7);

        SqlDataReader dr2 = command2.ExecuteReader();
        string texts2 = TextBox1.Text;

        while (dr2.Read())
        {
            SqlConnection con8 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
            con8.Open();

            SqlDataAdapter adapter2 = new SqlDataAdapter();

            adapter2.SelectCommand = new SqlCommand("Select postid from broadcast where post = '" + texts2 + "'", con8);
            try
            {
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);
                int pid = Convert.ToInt32(ds2.Tables[0].Rows[0]["postid"]);

                SqlCommand cmd2 = new SqlCommand("INSERT INTO relate(uid,pid) values (@uid,@postid)", con8);

                cmd2.CommandType = CommandType.Text;


                cmd2.Parameters.AddWithValue("@uid", dr2[0]); //cmd.Parameters.AddWithValue("@U_ID", );
                cmd2.Parameters.AddWithValue("@postid", pid); //cmd.Parameters.AddWithValue("@U_ID", );
                //    Response.Write(pid);
                //     cmd1.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                //    cmd1.Parameters["@ERROR"].Direction = ParameterDirection.Output;

                cmd2.ExecuteNonQuery();
                con8.Close();

            





        }

       
            catch (Exception exe)
            {
                Response.Write(exe.Message);
                con8.Close();
            }
            con7.Close();
            Response.Redirect("acc1.aspx");
        }



    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string post = TextBox1.Text;
        int user = Convert.ToInt32(Session["uid"]);

        SqlConnection con9 = new SqlConnection();

        con9.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

        con9.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO broadcast(uid,post) values (@uid,@post)", con9);


            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@uid", user); //cmd.Parameters.AddWithValue("@U_ID", );
            cmd.Parameters.AddWithValue("@post", post); //cmd.Parameters.AddWithValue("@U_ID", );

            cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
            cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();


            con9.Close();





        }

        catch (Exception exc)
        {
        }


        SqlConnection con10 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
        con10.Open();




        string broadcasttouser3 = "select uid from signup";
        SqlCommand command2 = new SqlCommand(broadcasttouser3, con10);

        SqlDataReader dr3 = command2.ExecuteReader();
        string texts3 = TextBox1.Text;

        while (dr3.Read())
        {
            SqlConnection con11 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
            con11.Open();

            SqlDataAdapter adapter3 = new SqlDataAdapter();

            adapter3.SelectCommand = new SqlCommand("Select postid from broadcast where post = '" + texts3 + "'", con11);

            try
            {
                DataSet ds3 = new DataSet();
                adapter3.Fill(ds3);
                int pid = Convert.ToInt32(ds3.Tables[0].Rows[0]["postid"]);

                SqlCommand cmd3 = new SqlCommand("INSERT INTO relate(uid,pid) values (@uid,@postid)", con11);

                cmd3.CommandType = CommandType.Text;


                cmd3.Parameters.AddWithValue("@uid", dr3[0]); //cmd.Parameters.AddWithValue("@U_ID", );
                cmd3.Parameters.AddWithValue("@postid", pid); //cmd.Parameters.AddWithValue("@U_ID", );
                //    Response.Write(pid);
                //     cmd1.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                //    cmd1.Parameters["@ERROR"].Direction = ParameterDirection.Output;

                cmd3.ExecuteNonQuery();
                con11.Close();







            }


            catch (Exception exe)
            {
                Response.Write(exe.Message);
                con11.Close();
            }
            con10.Close();
            Response.Redirect("acc1.aspx");
        }

    }
}

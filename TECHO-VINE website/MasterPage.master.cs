using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class MasterPage : System.Web.UI.MasterPage
{
    int t=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
         SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();


        con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
        con.Open();
        String s0 = "select count(*) from signup where emailid= '" + Login1.UserName + "'";
        SqlCommand count = new SqlCommand(s0, con);
        int temp = Convert.ToInt32(count.ExecuteScalar().ToString());

        if (temp == 1)
        {
           // Response.Write("Welcome");
            String s1 = "Select password from signup where emailid = '" + Login1.UserName + "'";
            SqlCommand pass = new SqlCommand(s1, con);
            String password = pass.ExecuteScalar().ToString();
            Response.Write("<script LANGUAGE='JavaScript'>alert('"+password+"')</script>");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            if (password == Login1.Password)
            {
                e.Authenticated = true;
                //Response.Write("Welcome");
                Session.Add("New", Login1.UserName);
                t = 1;
                


            }
            else
            {

                Login1.FailureText = "Check the password again";
                //e.Authenticated = false;
                //  Response.Write("Check again");
            }
        }
        else
        {

            Login1.FailureText = "No such user exists";
            //e.Authenticated = false;
            //Response.Write("No such user exist");
        }
        
       

    }



    protected void LoginButton_Click(object sender, EventArgs e)
    {

        // Response.Redirect(@"C:\Users\japa\Documents\Visual Studio 2010\WebSites\WebSite1\acc1.aspx");

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();

        con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
        con.Open();
        String s0 = "select count(*) from signup where emailid= '" + Login1.UserName + "'";
        SqlCommand count = new SqlCommand(s0, con);
        int temp = Convert.ToInt32(count.ExecuteScalar().ToString());

        if (temp == 1)
        {
           // Response.Write("Welcome");
            String s1 = "Select password from signup where emailid = '" + Login1.UserName + "'";
            SqlCommand pass = new SqlCommand(s1, con);
            String password = pass.ExecuteScalar().ToString();
            //Response.Write("<script LANGUAGE='JavaScript'>alert('" + password + "')</script>");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            if (password == Login1.Password)
            {
                //e1.Authenticated = true;

                //Response.Write("Welcome");
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select uid,firstname,dept,lastname,propic from signup where emailid = '" + Login1.UserName + "'", con1);
                //SqlCommand cmd = new SqlCommand("Select uid,firstname from signup where emailid = '" + Login1.UserName + "'", con1);
                con1.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                Session["Name"] = Convert.ToString(ds.Tables[0].Rows[0]["firstname"]);
                Session["email"] = Convert.ToString(Login1.UserName);
                Session["uid"] = Convert.ToString(ds.Tables[0].Rows[0]["uid"]);
                Session["dept"] = Convert.ToString(ds.Tables[0].Rows[0]["dept"]);
                Session["lname"] = Convert.ToString(ds.Tables[0].Rows[0]["lastname"]);
                Session["picc"] = Convert.ToString(ds.Tables[0].Rows[0]["propic"]);
                //Session["Name"] = cmd.ExecuteScalar();


                con1.Close();

     
                Session.Add("New", Login1.UserName);
                t = 1;
                Response.Redirect("acc1.aspx");
            


            }
            else
            {

                Login1.FailureText = "Check the password again";
                //e.Authenticated = false;
                //  Response.Write("Check again");
            }
        }
        else
        {

            Login1.FailureText = "No such user exists";
            //e.Authenticated = false;
            //Response.Write("No such user exist");
        }




            //Response.Redirect("acc1.aspx");
            //Response.Redirect("acc1.aspx");

            //Response.Redirect("acc1.aspx");



        
     }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click1(object sender, EventArgs e)
    {

    }
}



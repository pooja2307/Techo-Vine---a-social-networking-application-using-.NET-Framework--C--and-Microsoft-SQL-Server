using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


public partial class profile : System.Web.UI.Page
{
   // int usern;
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        s = Request.QueryString["user"];

        

        if (s == null)
        {

            if (Session["uid"] != null)
            {
                s = Session["uid"].ToString();

            }
            
        }
        Session["news"] = Convert.ToString(s);
          SqlConnection con3 = new SqlConnection();
         con3.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
         SqlDataAdapter adapter1 = new SqlDataAdapter();
         adapter1.SelectCommand = new SqlCommand("Select firstname,dept,lastname,propic,emailid,status from signup where uid = '" + s + "'", con3);
        //SqlCommand cmd = new SqlCommand("Select uid,firstname from signup where emailid = '" + Login1.UserName + "'", con1);
         con3.Open();
         DataSet ds = new DataSet();
         adapter1.Fill(ds);
        string s1 = Convert.ToString(ds.Tables[0].Rows[0]["firstname"]);
          
              string s2  = Convert.ToString(ds.Tables[0].Rows[0]["lastname"]);
          /*     string s3  = Convert.ToString(ds.Tables[0].Rows[0]["dept"]);
             string s4   =Convert.ToString(ds.Tables[0].Rows[0]["emailid"]); */
             string s5   = Convert.ToString(ds.Tables[0].Rows[0]["propic"]);
        // string s6  = Convert.ToString(ds.Tables[0].Rows[0]["status"]); 
        
        Label1.Text = Convert.ToString(s1);
        
        Label2.Text = Convert.ToString(s2);

      //  usern = Convert.ToInt32(s3);
        Image1.ImageUrl = Convert.ToString(s5);
         


        /* String pic = "select propic from signup where emailid='" + Session["email"] + "'";
        SqlCommand checkUser = new SqlCommand(pic, con);
        String temp = checkUser.ExecuteScalar().ToString();
        con.Close();
        if (temp.Equals(""))
        {
            Image1.ImageUrl = Convert.ToString(temp);
        }
        else
        {
            Image1.ImageUrl = "~/images/bg1.jpg";
        } */
        myposts();

    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void myposts()
    {
       
        SqlConnection con = null;
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
        con.Open();

        string ids = "select postid from broadcast where uid='" + s + "' order by postid desc";

        SqlCommand command = new SqlCommand(ids, con);
        SqlDataReader dr = command.ExecuteReader();

        while (dr.Read())
        {
            //string userids = "select uid from broadcast where postid='" + dr[0].ToString() + "'";
            string posttext = " select post from broadcast where postid='" + dr[0].ToString() + " ' ";

            //Response.Write(dr[0].ToString());
            //SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
            //con1.Open();

            //SqlCommand command1 = new SqlCommand(userids, con1);
            //int userid = Convert.ToInt32(command1.ExecuteScalar().ToString());
           // con1.Close();
            //    Response.Write(userid);
            /*string fname = "select firstname from signup where uid='" + userid + "'";
            string lname = "select lastname from signup where uid='" + userid + "'";
            string dname = "select dept from signup where uid='" + userid + "'";

            con1.Open();
            SqlCommand command2 = new SqlCommand(fname, con1);
            string fnm = command2.ExecuteScalar().ToString();
            Label l1 = new Label();
            l1.Text = fnm;
            Panel1.Controls.Add(l1);
            Panel1.Controls.Add(new LiteralControl("\t "));

            con1.Close();

            con1.Open();
            SqlCommand command3 = new SqlCommand(lname, con1);
            string lastn = command3.ExecuteScalar().ToString();
            Label l2 = new Label();
            l2.Text = lastn;
            Panel1.Controls.Add(l2);
            Panel1.Controls.Add(new LiteralControl("\t"));
            Panel1.Controls.Add(new LiteralControl("\t"));
            Panel1.Controls.Add(new LiteralControl("\t"));
            Panel1.Controls.Add(new LiteralControl("\t"));
            Panel1.Controls.Add(new LiteralControl("\t"));
            Panel1.Controls.Add(new LiteralControl("\t"));
            Panel1.Controls.Add(new LiteralControl("\t"));


            con1.Close();

            con1.Open();
            SqlCommand command4 = new SqlCommand(dname, con1);
            string deptn = command4.ExecuteScalar().ToString();
            Label l3 = new Label();
            l3.Text = deptn;
            Panel1.Controls.Add(new LiteralControl("("));

            Panel1.Controls.Add(l3);
            Panel1.Controls.Add(new LiteralControl(")"));
            Panel1.Controls.Add(new LiteralControl("<br />"));
            Panel1.Controls.Add(new LiteralControl("<br />"));



            con1.Close(); */
            SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
            con1.Open();
            SqlCommand command5 = new SqlCommand(posttext, con1);
            string postt = command5.ExecuteScalar().ToString();
            Label l4 = new Label();
            l4.Text = postt;
            Panel1.Controls.Add(l4);
            Panel1.Controls.Add(new LiteralControl("<br >"));
            Panel1.Controls.Add(new LiteralControl("<br />"));
            Panel1.Controls.Add(new LiteralControl("<br />"));
            Panel1.Controls.Add(new LiteralControl("<br />"));
            con1.Close();


        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Delete.aspx");
        
    }
}
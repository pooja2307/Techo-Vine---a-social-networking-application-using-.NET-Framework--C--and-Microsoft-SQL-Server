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
    int usern;

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Convert.ToString(Session["Search"]);
        Label2.Text = Convert.ToString(Session["lname"]);
        usern = Convert.ToInt32(Session["uid"]);
        
        SqlConnection con = null;


        con = new SqlConnection(ConfigurationManager.ConnectionStrings["techovine"].ConnectionString);

        con.Open();


        String fname = "select propic from signup where emailid='" + Session["email"] + "'";
        SqlCommand checkUser = new SqlCommand(fname, con);
        String temp = checkUser.ExecuteScalar().ToString();
        con.Close();
        if (temp.Equals(""))
        {
            Image1.ImageUrl = "~/images/bg1.jpg";
        }
        else
        {
            Image1.ImageUrl = "~/images/bg1.jpg";
        }
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

        string ids = "select postid from broadcast where uid='" + usern + "'";

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
}
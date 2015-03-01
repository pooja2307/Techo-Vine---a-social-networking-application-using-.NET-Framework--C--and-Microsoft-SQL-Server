using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Defnew : System.Web.UI.Page
{
    /* string sql;
    DataBaseClass dbClass = new DataBaseClass();
    public DataTable dt; */
   

    int usern;

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Convert.ToString(Session["Name"]);
        Image1.ImageUrl = Convert.ToString(Session["picc"]);
        usern = Convert.ToInt32(Session["uid"]);
        //Response.Write(Session["Name"].ToString());
        broadcast();
      

    }

    protected void broadcast()
    {
        SqlConnection con = null;
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
        con.Open();
        try
        {

            string ids = "select pid from relate where uid='" + usern + "'  order by pid desc ";

            SqlCommand command = new SqlCommand(ids, con);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                string userids = "select uid from broadcast where postid='" + dr[0].ToString() + "'";
                string posttext = " select post from broadcast where postid='" + dr[0].ToString() + " ' ";

                //Response.Write(dr[0].ToString());
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
                con1.Open();

                SqlCommand command1 = new SqlCommand(userids, con1);
                int userid = Convert.ToInt32(command1.ExecuteScalar().ToString());
                con1.Close();
                //    Response.Write(userid);
                string fname = "select firstname from signup where uid='" + userid + "'";
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



                con1.Close();

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
        catch (Exception)
        { }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("acc1.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

       Session.Abandon();
       Session.Clear();
       Response.Redirect("start.aspx");
   
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

    }
    /*public void GetSearchResult(string searchText)
    {
        string GetSearchResult = "Select * FROM [User] where Name like '" + searchText + "%'";
        dt = dbClass.ConnectDataBaseReturnDT(GetSearchResult);
        if (dt.Rows.Count > 0)
        {
            SearchResultList.DataSource = dt;
            SearchResultList.DataBind();
        }
    }*/
    protected void Button5_Click1(object sender, EventArgs e)
    {
       
       //string sql = "select firstname from signup where firstname like '" + TextBox1.Text + "%'";

       Session["search"]= TextBox1.Text ;
       Response.Redirect("Search_Result.aspx"); 
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Broadcast.aspx"); 
    }
    
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("TechoPage.aspx");
    }
}
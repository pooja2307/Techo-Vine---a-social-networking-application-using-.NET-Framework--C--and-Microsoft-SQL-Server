using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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


public partial class _admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string emailid = TextBox1.Text;
        string type = TextBox2.Text;

        SqlConnection con2 = new SqlConnection();

        con2.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

        con2.Open();

        String s0 = "select count(*) from admin where email= '" + TextBox1.Text + "'";
        SqlCommand count = new SqlCommand(s0, con2);
        int temp = Convert.ToInt32(count.ExecuteScalar().ToString());
        con2.Close();
        if (temp == 0)
        {
            SqlConnection con1 = new SqlConnection();

            con1.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

            con1.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO admin(email,type) values (@email,@type)", con1);


            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.AddWithValue("@email", emailid); //cmd.Parameters.AddWithValue("@U_ID", );
            cmd1.Parameters.AddWithValue("@type", type);

            cmd1.Parameters.Add("@ERROR", SqlDbType.Char, 500);
            cmd1.Parameters["@ERROR"].Direction = ParameterDirection.Output;
            cmd1.ExecuteNonQuery();
            //message = (string)cmd.Parameters["@ERROR"].Value; 
            TextBox1.Text ="";
            TextBox2.Text = "";

            con1.Close();

            Label3.Text = "Inserted";
            Label3.Enabled = true;
            Label3.Visible = true;

            /* catch (Exception exc)
            {
            } */
        }
        else
        {
           
            TextBox1.Text = "";
            TextBox2.Text = "";

            Label3.Text = "already exists";
            Label3.Enabled = true;
            Label3.Visible = true;
        }
        
    }
        protected void Button2_Click(object sender, EventArgs e)
    {
string emailid = TextBox1.Text;
                    string type = TextBox2.Text;
        SqlConnection con2 = new SqlConnection();

                                    con2.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

                                    con2.Open();



                                    SqlCommand cmd2 = new SqlCommand("DELETE from admin where email='"+emailid+"'", con2);


                                    cmd2.CommandType = CommandType.Text;

                               cmd2.ExecuteNonQuery();
                                    //message = (string)cmd.Parameters["@ERROR"].Value; 
                                    con2.Close();
                                    TextBox1.Text = "";
                                    TextBox2.Text = "";

                                    Label3.Text = "Deleted";
                                    Label3.Enabled = true;
                                    Label3.Visible = true;


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
/*
        string emailid = TextBox1.Text;
        string type = TextBox2.Text;
        SqlConnection con2 = new SqlConnection();

        con2.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

        con2.Open();



        SqlCommand cmd2 = new SqlCommand("SELECT * from admin ", con2);


        cmd2.CommandType = CommandType.Text;

        cmd2.ExecuteNonQuery(); */
        DataList1.Enabled = true;
        DataList1.Visible = true;
        //message = (string)cmd.Parameters["@ERROR"].Value; 
        //con2.Close();
                                    

    }

    protected void DataList1_SelectedIndexChanged(object sender, System.EventArgs e)
    {

    }
}
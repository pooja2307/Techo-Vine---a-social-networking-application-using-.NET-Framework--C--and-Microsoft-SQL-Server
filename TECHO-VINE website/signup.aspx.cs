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

public partial class Sign : System.Web.UI.Page
{
    string pat;
    string user;
    string root;
    protected void Page_Load(object sender, EventArgs e)
    {
        root = Server.MapPath("~/");
        
     
            if (!root.EndsWith(@"\"))
            {
                // clean up the path
                root += @"\";
            }

            pat = root + @"\images\";

        
       /* else
        {
            Response.Redirect("start.aspx");
        } */
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         string email = TextBox4.Text;

         SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();


        con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
        con.Open();
        String s0 = "select count(*) from admin where email= '" + email + "'";
        SqlCommand count = new SqlCommand(s0, con);
        int temp = Convert.ToInt32(count.ExecuteScalar().ToString());
        
        if (temp == 1)
        {
            //Response.Write("Welcome");
            String s1 = "Select type from admin where email = '" + email + "'";
            SqlCommand pass = new SqlCommand(s1, con);
            String type = pass.ExecuteScalar().ToString();
            //Response.Write("<script LANGUAGE='JavaScript'>alert('"+password+"')</script>");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            if (type == RadioButtonList1.SelectedItem.ToString())
            {



                if (TextBox6.Text == TextBox5.Text && TextBox5.Text != null)
                {
                    string FirstName = TextBox1.Text;
                    string LastName = TextBox2.Text;
                    string Department = TextBox3.Text;
                    string EmailId = TextBox4.Text;
                    string Password = TextBox5.Text;
                    string Conpwd = TextBox6.Text;
                    string Type = RadioButtonList1.Text;
                    string Phoneno = TextBox7.Text;
                    string Status = TextBox8.Text;
                    string Propic = "";
                    if (FileUpload1.HasFile)
                    {
                        try
                        {
                            if ((FileUpload1.PostedFile.ContentType == "image/jpeg") ||
                                (FileUpload1.PostedFile.ContentType == "image/gif") ||
                                (FileUpload1.PostedFile.ContentType == "image/jpg") ||
                                (FileUpload1.PostedFile.ContentType == "image/png") ||
                                (FileUpload1.PostedFile.ContentType == "image/bmp"))
                            {
                                if (Convert.ToInt32(FileUpload1.PostedFile.ContentLength) < 20971520)
                                {

                                    string extension = Path.GetExtension(FileUpload1.FileName);
                                    string uniquefilename = Path.ChangeExtension(FileUpload1.FileName, DateTime.Now.Ticks.ToString());
                                    Propic = Path.Combine(@"images\", uniquefilename + extension);


                                    FileUpload1.SaveAs(Path.Combine(pat, uniquefilename + extension));

                                    SqlConnection con1 = new SqlConnection();

                                    con1.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

                                    con1.Open();



                                    SqlCommand cmd1 = new SqlCommand("INSERT INTO signup(firstname,lastname,dept,emailid,password,type,phoneno,status,propic) values (@firstname,@lastname,@dept,@emailid,@password,@type,@phoneno,@status,@propic)", con1);


                                    cmd1.CommandType = CommandType.Text;

                                    cmd1.Parameters.AddWithValue("@firstname", FirstName); //cmd.Parameters.AddWithValue("@U_ID", );
                                    cmd1.Parameters.AddWithValue("@lastname", LastName);
                                    cmd1.Parameters.AddWithValue("@dept", Department);
                                    cmd1.Parameters.AddWithValue("@emailid", EmailId);
                                    cmd1.Parameters.AddWithValue("@password", Password);
                                    cmd1.Parameters.AddWithValue("@type", Type);
                                    cmd1.Parameters.AddWithValue("@phoneno", Phoneno);
                                    cmd1.Parameters.AddWithValue("@status", Status);
                                    cmd1.Parameters.AddWithValue("@propic", Propic);
                                    cmd1.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                                    cmd1.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                                    cmd1.ExecuteNonQuery();
                                    //message = (string)cmd.Parameters["@ERROR"].Value; 
                                    con1.Close();
                                    Response.Redirect("start.aspx");


                                    /* catch (Exception exc)
                                    {
                                    } */
                                }

                                else
                                {
                                    
                                    Label1.Text="Password doesnot match";
                                    Label1.Enabled = true;
                                    Label1.Visible = true;
                                    //Label1.Visible = true;

                                    //Page.RegisterStartupScript("UserMsg", "<Script language='javascript'>alert('" + "Password mismatch" + "');</script>");

                                } //lblErrorMsg.Text = message;
                            }
                        }
                        catch { }
                    }


                }
            }
            else
            {

                Label1.Text = "NOT APPROVED BY ADMINISTRATOR!!";
                Label1.Enabled = true;
                Label1.Visible = true;
               
            }
             }
        else
        {
            Label1.Enabled = true;
            Label1.Visible = true;
            //  string err="No such student or faculty exists";
        //Response.Write("<script LANGUAGE='JavaScript'>alert('"+err+"')</script>");  
        }
        
     con.Close();  
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
}

   
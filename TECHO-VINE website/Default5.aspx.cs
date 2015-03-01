using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;


public partial class Def5 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();


    protected void Page_Load(object sender, EventArgs e)
    {

        con.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;
        if (!IsPostBack)
        {

            int user = Convert.ToInt32(Session["uid"]);
      

            con.Open();



            // SqlCommand cmd = new SqlCommand("Select firstname from signup where uid='"+user+"'", con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = new SqlCommand("Select * from signup where uid='" + user + "'", con);
            adapter.Fill(ds);


            string fname = Convert.ToString(ds.Tables[0].Rows[0]["firstname"]);

            string lname = Convert.ToString(ds.Tables[0].Rows[0]["lastname"]);
            string email = Convert.ToString(ds.Tables[0].Rows[0]["emailid"]);
            string dept = Convert.ToString(ds.Tables[0].Rows[0]["dept"]);
            string pass = Convert.ToString(ds.Tables[0].Rows[0]["password"]);
            string phone = Convert.ToString(ds.Tables[0].Rows[0]["phoneno"]);
            string status = Convert.ToString(ds.Tables[0].Rows[0]["status"]);
            string pic = Convert.ToString(ds.Tables[0].Rows[0]["propic"]);
            //Session["Name"] = cmd.ExecuteScalar();



            


            TextBox9.Text = fname;
            TextBox10.Text = lname;
            TextBox11.Text = email;
            TextBox12.Text = pass;
            TextBox13.Text = pass;
            TextBox14.Text = dept;
            TextBox16.Text = status;
            //FileUpload1.SaveAs("");

            TextBox17.Text = phone;
            //Response.Write("falguni" +fname);
            // FileUpload1. = pic;

            //con.Close();
       

        }





    }
    protected void Button1_hu(object sender, EventArgs e)
    {
        //if (TextBox12.Text == TextBox13.Text && TextBox12.Text != null)
        //{
        string pat;
      
        string root;
        root = Server.MapPath("~/");


        if (!root.EndsWith(@"\"))
        {
            // clean up the path
            root += @"\";
        }

        pat = root + @"\images\";
         int usern = Convert.ToInt32(Session["uid"]);
            string FirstName = TextBox9.Text;
            string LastName = TextBox10.Text;
            string Department = TextBox14.Text;
            string EmailId = TextBox11.Text;
            string Password = TextBox12.Text;
            string Conpwd = TextBox13.Text;
            //string Type= RadioButtonList1.Text;
            string Phoneno = TextBox17.Text;
            string Status = TextBox16.Text;
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
                        }
                    }}
            catch (Exception eee)
                {}
           
            //con.Open();
            SqlConnection con2 = new SqlConnection();

            con2.ConnectionString = ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString;

            con2.Open();

                SqlCommand cmd2 = new SqlCommand("UPDATE signup SET status='"+Status+"' where uid="+usern,con2); //astname='" + LastName + "',dept='" + Department + "',emailid="'" + EmailId + "',password='" + Password + "',phoneno='" + Phoneno + "',status='" +Status+"' 
                //SqlParameter param = new SqlParameter("@stat",50);
               // param.Value = Status;
               // cmd2.Parameters.Add(param);
                // param1 = new SqlParameter();
               
                //cmd2.Parameters.AddWithValue("@us", usern);
                //cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();
                con2.Close();
                con2.Open();
                SqlCommand cmd1 = new SqlCommand("Update signup set password='" + Password + "' where uid='"+usern+"'" , con2);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();
                con2.Close();
                con2.Open();
               SqlCommand cmd3 = new SqlCommand("Update signup set propic='" + Propic + "' where uid='"+usern+"'" , con2);
                cmd3.CommandType = CommandType.Text;
                cmd3.ExecuteNonQuery();
                

                /* cmd.Parameters.AddWithValue("@firstname", FirstName); //cmd.Parameters.AddWithValue("@U_ID", );
                 cmd.Parameters.AddWithValue("@lastname", LastName);
                 cmd.Parameters.AddWithValue("@dept", Department);
                 cmd.Parameters.AddWithValue("@emailid", EmailId);
                 cmd.Parameters.AddWithValue("@password", Password);
                 cmd.Parameters.AddWithValue("@type", Type);
                 cmd.Parameters.AddWithValue("@phoneno", Phoneno);
                 cmd.Parameters.AddWithValue("@status", Status); */
                //cmd.Parameters.AddWithValue("@propic", Propic); 
                //cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                //cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                //cmd.ExecuteNonQuery();

                //message = (string)cmd.Parameters["@ERROR"].Value; 
                con2.Close();
                // Response.Redirect("acc1.aspx");
            
            Response.Redirect("acc1.aspx");
        //}
        //else
        //{

            Label1.Text = "Invalid";

        
    
}
                    }
    
                }

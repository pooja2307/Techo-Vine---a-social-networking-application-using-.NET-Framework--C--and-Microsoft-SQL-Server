using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class abcd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (Login1.UserName == "user1")
        {
            if (Login1.Password == "password1")
            {
                e.Authenticated = true;

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
            Login1.FailureText = "Incorrect username and password";
        }
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        if (Login1.UserName == "user1")
        {
            if (Login1.Password == "password1")
            {
                Response.Redirect("admin.aspx");
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
            Login1.FailureText = "Incorrect username and password";
        }
    }
   
}
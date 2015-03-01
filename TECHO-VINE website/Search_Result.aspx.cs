using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class search : System.Web.UI.Page
{
    //SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["techoVine"].ConnectionString);
    
    protected void Page_Load(object sender, EventArgs e)
    {
       /* DataList DataList2 = new DataList();
        string sql = "select firstname from signup where firstname like '" + Session["search"] + "%'";
        SqlCommand cmd1 = new SqlCommand(sql, con2);
        //string sql = "select firstname from signup where firstname like '" + TextBox1.Text + "%'";
        con2.Open();

        SqlDataReader dr = cmd1.ExecuteReader();
        DataList2.DataSource = dr;
        DataList2.DataBind();*/
         
    }
     protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
     protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
     {

     }
     protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
     {
         
     }
     protected void DataList2_SelectedIndexChanged1(object sender, EventArgs e)
     {

     }
     protected void DataList3_SelectedIndexChanged(object sender, EventArgs e)
     {
         Session["select"] = Convert.ToString(DataList3.SelectedItem);
        
        
     }
     protected void SqlDataSource1_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
     {

     }
}

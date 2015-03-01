<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search_Result.aspx.cs" Inherits="search" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 0px;
        }
    </style>
    </head>
<body background="images/bg23.jpg">
    <form id="form1" runat="server">
    <div style="height: 388px; background-color: #33CCCC; font-family: Broadway; font-size: medium;">
    
        <br />
        <br />
    
        Search Results.....Click on the name to visit profile.<br />
        <br />
        <br />
    
        <asp:DataList ID="DataList3" runat="server" DataSourceID="SqlDataSource1" 
            onselectedindexchanged="DataList3_SelectedIndexChanged" 
            Font-Names="Broadway" Font-Size="Medium" ForeColor="White">
            <ItemTemplate>
                 <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("url") %>' runat="server">  &nbsp;<asp:Label ID="firstnameLabel" runat="server" 
                    Text='<%# Eval("firstname") %>' /> 
                &nbsp;<asp:Label ID="lastnameLabel" runat="server" Text='<%# Eval("lastname") %>' />
&nbsp;<asp:Label ID="emailidLabel" runat="server" Text='<%# Eval("emailid") %>' />
                </asp:HyperLink><br /><br /></ItemTemplate></asp:DataList><asp:SqlDataSource 
            ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:techoVine %>" 
            
            
            SelectCommand="SELECT [firstname], [lastname], [emailid], ('profile.aspx?user=' + CONVERT(varchar(50),[uid])) AS url FROM [signup] WHERE ([firstname] LIKE '%' + @firstname + '%')" 
            onselecting="SqlDataSource1_Selecting1"><SelectParameters>
                <asp:SessionParameter Name="firstname" SessionField="search" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    <br /><br /><br /><br /><br /><br /></div>
    <table class="style1">
        <tr>
            <td>
                <asp:Button ID="Button7" runat="server" BackColor="Black" Font-Names="Broadway" 
                    Font-Size="Large" ForeColor="White" Height="38px" PostBackUrl="~/acc1.aspx" 
                    Text="HOME" Width="177px" /></td></tr></table></form></body></html>
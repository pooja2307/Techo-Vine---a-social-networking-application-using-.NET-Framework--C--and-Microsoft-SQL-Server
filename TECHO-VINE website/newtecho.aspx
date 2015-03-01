<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newtecho.aspx.cs" Inherits="newtecho" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="images/bg10.jpg">
    <form id="form1" runat="server">
    <div>
    
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="SqlDataSource1" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:techoVine %>" 
            onselecting="SqlDataSource1_Selecting" 
            SelectCommand="SELECT * FROM [techo_images]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>

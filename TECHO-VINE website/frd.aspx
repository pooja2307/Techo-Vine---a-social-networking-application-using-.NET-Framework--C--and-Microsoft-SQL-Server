<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 214px;
        }
        .style3
        {
            width: 212px;
        }
        .style4
        {
            width: 210px;
        }
        .style5
        {
            width: 100%;
            height: 2130px;
        }
        .style6
        {
            width: 212px;
            height: 63px;
        }
        .style7
        {
            height: 63px;
        }
        .style8
        {
            height: 931px;
        }
    </style>
</head>
<body background="images/bg10.jpg">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table class="style1" align="center" style="border: thick solid #008080">
        <tr>
            <td class="style4" style="background-color: #008080">
                <asp:Image ID="Image1" runat="server" Height="208px" Width="209px" />
            </td>
            <td bgcolor="Yellow" align="center">
                <asp:Label ID="Label1" runat="server" ForeColor="#009999" Align="Center" 
                    Text="Label" Font-Bold="True" Font-Names="Broadway" Font-Size="X-Large" 
                    Font-Underline="True"></asp:Label>
                           
            &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" ForeColor="#009999" Align="Center" 
                    Text="Label" Font-Bold="True" Font-Names="Broadway" Font-Size="X-Large" 
                    Font-Underline="True"></asp:Label>
                           
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <table class="style1" style="border: medium solid #000000">
        <tr>
            <td align="center" class="style3" 
                style="font-family: broadway; background-color: #FFFF00;">
                Department</td>
            <td style="font-family: broadway; color: #008080;">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" 
                    onselectedindexchanged="DataList1_SelectedIndexChanged">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="deptLabel" runat="server" Text='<%# Eval("dept") %>' />
                        <br />
<br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:techoVine %>" 
                    SelectCommand="SELECT [dept] FROM [signup] WHERE ([uid] = @uid)">
                    <SelectParameters>
                        <asp:SessionParameter Name="uid" SessionField="uid" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td align="center" class="style3" 
                style="font-family: broadway; background-color: #FFFF00">
                E-mail id:</td>
            <td style="font-family: broadway; color: #008080">
                <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource2">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="emailidLabel" runat="server" Text='<%# Eval("emailid") %>' />
                        <br />
<br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:techoVine %>" 
                    SelectCommand="SELECT [emailid] FROM [signup] WHERE ([uid] = @uid)">
                    <SelectParameters>
                        <asp:SessionParameter Name="uid" SessionField="uid" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td align="center" class="style6" 
                style="font-family: broadway; color: #008080; background-color: #000000">
                Status</td>
            <td class="style7">
                <asp:DataList ID="DataList3" runat="server" DataSourceID="SqlDataSource3">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="statusLabel" runat="server" Font-Names="Broadway" 
                            ForeColor="#009999" Text='<%# Eval("status") %>' />
                        <br />
<br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:techoVine %>" 
                    SelectCommand="SELECT [status] FROM [signup] WHERE ([uid] = @uid)">
                    <SelectParameters>
                        <asp:SessionParameter Name="uid" SessionField="uid" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <table class="style5">
        <tr>
            <td class="style8">
                <asp:Panel ID="Panel1" runat="server" 
                    BackImageUrl="~/bg/Background_website_640-480.JPG" BorderColor="Black" 
                    BorderStyle="Solid" Font-Names="Broadway" Font-Size="Large" ForeColor="Yellow" 
                    Height="2035px" style="margin-top: 0px">
                    My Posts...</asp:Panel>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 135px;
        }
        .style3
        {
            width: 212px;
        }
        .style4
        {
            width: 210px;
            height: 121px;
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
            width: 620px;
        }
        .style9
        {
            height: 121px;
        }
    </style>
</head>
<body background="images/bg23.jpg" >
    <form id="form1" runat="server">
    <div>
    
    &nbsp;</div>
    <table class="style1" align="center" 
        style="border: thick solid #008080; margin-top: 4px;" bgcolor="#0099FF">
        <tr>
            <td class="style4" style="background-color: #008080">
                <asp:Image ID="Image1" runat="server" Height="140px" Width="209px" 
                    BackColor="#00CCFF" />
            </td>
            <td bgcolor="Yellow" align="center" 
                style="border: thick dashed #000000; color: #000000; background-color: #33CCFF; font-family: Broadway; font-size: xx-large; font-style: normal; font-variant: normal;" 
                class="style9">
                techo-ite :&nbsp;
                <asp:Label ID="Label1" runat="server" ForeColor="Black" Align="Center" 
                    Text="Label" Font-Bold="True" Font-Names="Broadway" Font-Size="X-Large" 
                    Font-Underline="True"></asp:Label>
                           
            &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" ForeColor="Black" Align="Center" 
                    Text="Label" Font-Bold="True" Font-Names="Broadway" Font-Size="X-Large" 
                    Font-Underline="True"></asp:Label>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="HOME" 
            BackColor="Black" Font-Names="Broadway" Font-Size="Large" ForeColor="White" 
            Height="44px" PostBackUrl="~/acc1.aspx" Width="126px" />
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <table class="style1" style="border: medium solid #000000">
        <tr>
            <td align="center" class="style3" 
                
                style="border-style: none; border-color: #FFFFFF; font-family: Broadway; background-color: #000000; font-size: large; color: #00CCFF;">
                Department</td>
            <td style="font-family: broadway; color: #FFFFFF;">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" 
                    BorderStyle="Dashed" HorizontalAlign="Left">
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
                        <asp:SessionParameter Name="uid" SessionField="news" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td align="center" class="style3" 
                
                style="border-style: none; border-color: #FFFFFF; font-family: Broadway; background-color: #000000; font-size: large; color: #00CCFF;">
                E-mail id:</td>
            <td style="font-family: broadway; color: #FFFFFF">
                <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource2" 
                    BorderStyle="Dashed" HorizontalAlign="Left">
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
                        <asp:SessionParameter Name="uid" SessionField="news" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td align="center" class="style6" 
                
                style="border-style: none; border-color: #FFFFFF; font-family: Broadway; color: #00CCFF; background-color: #000000; font-size: large;">
                Status</td>
            <td class="style7" style="color: #000000; font-family: broadway;">
                <asp:DataList ID="DataList3" runat="server" DataSourceID="SqlDataSource3" 
                    ForeColor="White" BorderStyle="Dashed" HorizontalAlign="Left" 
                    Font-Size="Large">
                    <ItemTemplate>
                        &nbsp;<asp:Label ID="statusLabel" runat="server" Text='<%# Eval("status") %>' />
                        <br />
<br />
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:techoVine %>" 
                    SelectCommand="SELECT [status] FROM [signup] WHERE ([uid] = @uid)">
                    <SelectParameters>
                        <asp:SessionParameter Name="uid" SessionField="news" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
    <table class="style5">
        <tr>
            <td class="style8">
                <asp:Panel ID="Panel1" runat="server" BorderColor="#0099FF" 
                    BorderStyle="Ridge" Font-Names="Broadway" Font-Size="XX-Large" ForeColor="White" 
                    Height="2035px" style="margin-top: 0px" BackColor="Black" 
                    Font-Italic="False" ScrollBars="Auto">
                    My Posts...<br />
                    <br />
                </asp:Panel>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>

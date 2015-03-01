<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Broadcast.aspx.cs" Inherits="Broadcast" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 96%;
            height: 67px;
        }
        .style2
        {
            width: 163px;
        }
        .style3
        {
            width: 170px;
        }
        .style4
        {
            width: 199px;
        }
    </style>
</head>
<body background="images/bg23.jpg">
    <form id="form1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button7" runat="server" BackColor="Black" Font-Names="Broadway" 
        Font-Size="Large" ForeColor="White" Height="44px" PostBackUrl="~/acc1.aspx" 
        Text="HOME" Width="97px" />
    <br />
    
        <asp:Label ID="Label1" runat="server" Text="Broadcast your post here!! :)" 
            Font-Bold="True" Font-Names="Broadway" ForeColor="White" 
            BackColor="Black"></asp:Label>
    
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="277px" 
        ontextchanged="TextBox1_TextChanged" style="margin-left: 0px" 
        Width="836px" BackColor="Black" Font-Names="Broadway" Font-Size="Medium" 
        ForeColor="Yellow"></asp:TextBox>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" BorderColor="White" 
                    onclick="Button1_Click" Text="Only For Faculty" BackColor="#0099FF" 
                    Font-Names="Broadway" />
            </td>
            <td class="style3">
                <asp:Button ID="Button2" runat="server" Text="Only for Students" 
                    onclick="Button2_Click" BackColor="#0099FF" Font-Names="Broadway" 
                    style="margin-left: 16px" Width="154px" />
            </td>
            <td class="style4">
                <asp:Button ID="Button3" runat="server" Text="Only for your Department" 
                    onclick="Button3_Click" BackColor="#0099FF" Font-Names="Broadway" 
                    style="margin-left: 18px" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Text="For Techo " 
                    onclick="Button4_Click" BackColor="#0099FF" Font-Names="Broadway" 
                    style="margin-left: 19px" Width="128px" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>

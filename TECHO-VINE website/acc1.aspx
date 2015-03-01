<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeFile="acc1.aspx.cs" Inherits="Defnew" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style4
        {
            color: #FFFFFF;
            font-family: AdamGorry-Lights;
        }
        .style5
        {
            color: #FFFFFF;
            font-family: AdamGorry-Lights;
            font-size: xx-large;
        }
        #form1
        {
            height: 69px;
        }
        .style1
        {
            width: 100%;
            height: 535px;
            margin-left: 0px;
        }
        .style6
        {
            width: 329px;
        }
        .style8
        {
            width: 329px;
            height: 91px;
        }
    </style>
</head>
<body background="images/bg23.jpg">
    <form id="form1" runat="server">
    <br />
    <strong style="font-weight: 700"><span class="style5">
                    <asp:Image ID="Image1" runat="server" Height="133px" 
                        Width="182px" BorderColor="#33CCCC" BorderStyle="Dashed" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    welcome&nbsp; to techo-vine&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label" Font-Names="Broadway"></asp:Label>
    &nbsp;!!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span>
    <br class="style4" />
    <br />
    <br />
    </strong>
    <p>
    <table class="style1" align="center">
        <tr>
            <td class="style6">
                <strong style="font-weight: 700">
                <br />
                    <asp:Button ID="Button9" runat="server" BackColor="Black" 
                        Font-Names="Broadway" ForeColor="White" onclick="Button1_Click" 
                        PostBackUrl="~/acc1.aspx" Text="HOME" Height="24px" 
                    Width="122px" />
                    <br />
                <br />
                <br />
                    <asp:TextBox ID="TextBox1" runat="server" 
                        BorderColor="#00CCFF" Width="189px" Height="38px"></asp:TextBox>
                    <br />
                <br />
                    <asp:Button ID="Button5" runat="server" BackColor="Black" 
                        Font-Bold="True" Font-Names="Broadway" ForeColor="#0099FF" 
                        onclick="Button5_Click1" style="margin-top: 0px" Text="Search Friends" 
                    Height="37px" Width="182px" />
                    <br />
                <br />
                <br />
                </strong>
                    <asp:Button ID="Button7" runat="server" BackColor="Black" 
                        Font-Names="Broadway" ForeColor="White" Height="27px" onclick="Button7_Click" 
                        style="margin-right: 0px" Text="My Techo" Width="122px" />
                    <br />
                <br />
                <br />
                    <asp:Button ID="Button2" runat="server" BackColor="Black" 
                        Font-Names="Broadway" ForeColor="White" onclick="Button2_Click" 
                        Text="Broadcast" Height="26px" Width="120px" />
                    <br />
                <br />
&nbsp;<br />
                    <asp:Button ID="Button8" runat="server" BackColor="Black" 
                        Font-Names="Broadway" ForeColor="White" onclick="Button1_Click" 
                        PostBackUrl="~/Default5.aspx" Text="Edit My Profile" Height="24px" 
                    Width="122px" />
                    <br />
                <br />
                <br />
                    <asp:Button ID="Button6" runat="server" BackColor="Black" 
                        Font-Names="Broadway" ForeColor="White" onclick="Button1_Click" 
                        PostBackUrl="~/profile.aspx" Text=" My Profile" Height="24px" 
                    Width="122px" />
                    <br />
                <br />
                <br />
                    <asp:Button ID="Button4" runat="server" BackColor="Black" 
                        Font-Names="Broadway" ForeColor="White" onclick="Button4_Click" 
                        Text="Logout" Height="23px" Width="123px" />
                    <br />
            </td>
            <td rowspan="2">
                <asp:Panel ID="Panel1" runat="server" BackColor="Black" ForeColor="White" 
                    Height="1303px" style="margin-top: 0px; margin-left: 0px;" 
                    Font-Names="Broadway" Font-Size="Large" BorderColor="#33CCCC" 
                    BorderStyle="Dashed" ScrollBars="Auto">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Broadway" 
                        Font-Size="X-Large" Text="My Notice Board" ForeColor="Black" 
                        style="color: #FFFFFF"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Panel ID="Panel3" runat="server">
                        <br />
                    </asp:Panel>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style8">
            </td>
        </tr>
        </table>
        &nbsp;&nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>

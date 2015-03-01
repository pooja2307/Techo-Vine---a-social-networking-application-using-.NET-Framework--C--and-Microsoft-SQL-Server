<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Def5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

  
    
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 100%;
            height: 622px;
            margin-top: 96px;
        }
        .style5
        {
            width: 88%;
            height: 525px;
            margin-top: 0px;
        }
        .style6
        {
            width: 121px;
        }
        .style7
        {
            width: 121px;
            height: 91px;
        }
        .style8
        {
            height: 91px;
        }
        .style9
        {
            width: 121px;
            height: 62px;
        }
        .style10
        {
            height: 62px;
        }
        .style11
        {
            width: 121px;
            height: 165px;
        }
        .style12
        {
            height: 165px;
        }
        .style13
        {
            text-align: center;
        }
        .style14
        {
            font-size: x-large;
        }
    </style>
</head>
<body background="images/bg23.jpg">
    <form id="form2" runat="server">
    <div style="height: 58px; font-family: broadway; font-size: large; color: #FFFFFF; background-color: #000000;" 
        class="style13">
    
        <strong><span class="style14">Edit your Profile Here!!</span></strong><br />
        <br />
    
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="Black" Font-Bold="True" 
            Font-Names="Broadway" ForeColor="White" PostBackUrl="~/acc1.aspx" 
            Text="HOME" Height="42px" Width="111px" />
        <br />
    
    </div>
    <table align="center" class="style1">
        <tr>
            <td align="justify" 
                
                
                
                style="font-family: broadway; font-size: x-small; color: #FFFF00; background-color: #000000">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <table class="style5">
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            Firstname*</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TextBox9" ErrorMessage="Required field!" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            Lastname*</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TextBox10" ErrorMessage="RequiredFieldValidator" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            Email id*</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="TextBox11" ErrorMessage="RegularExpressionValidator" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                ForeColor="White"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="TextBox11" ErrorMessage="Required field!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            New Password*</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox12" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="TextBox12" ErrorMessage="Required field!" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            Confirm password*</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox13" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="TextBox13" ErrorMessage="Required field" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            Department*</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ErrorMessage="Required field!" ControlToValidate="TextBox14" 
                                ForeColor="White"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="color: #FFFFFF; font-family: Broadway">
                            New profile picture</td>
                        <td style="color: #0099FF; font-family: Broadway">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style7" style="color: #FFFFFF; font-family: Broadway">
                            Update Status</td>
                        <td class="style8" style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox16" runat="server" Height="66px" Width="777px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style9" style="color: #FFFFFF; font-family: Broadway">
                            Contact no</td>
                        <td class="style10" style="color: #0099FF; font-family: Broadway">
                            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style11">
                            <asp:Button ID="Button1" runat="server" BackColor="White" 
                                Font-Names="Broadway" ForeColor="Black" Text="Update" Width="119px" 
                                onclick="Button1_hu" />
                        </td>
                        <td class="style12">
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
&nbsp;</td>
        </tr>
        <tr>
            <td align="justify">
                &nbsp;</td>
        </tr>
    </table>
    </form>
    <div>
    
    </div>
    </form>
</body>
</html>

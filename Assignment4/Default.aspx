<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Be a Donor</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <div class="wrap">
    <form id="form1" runat="server">
    <div>
    <h2>Log In</h2>
        <table>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="UserEmailTextBox" runat="server" TextMode="Email" Height="23px" Width="239px" ></asp:TextBox></td>
        </tr>
        
        <tr>
            <td>
                Password
            </td>
            <td>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Height="24px" Width="240px"></asp:TextBox></td>
        </tr>

        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="LoginButton" runat="server" Text="Log in" OnClick="LoginButton_Click" Width="150px" />
            </td>
        </tr>
    </table>
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label><br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Register.aspx">Register here to donate</asp:LinkButton>
    </div>
    </form>
        </div>
</body>
</html>

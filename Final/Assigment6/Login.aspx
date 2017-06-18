<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    
        <div class="wrap">
            
    <form id="form2" runat="server">
    <div>
    <h2>Log In</h2>
        <table>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server" TextMode="Email" Height="23px" Width="239px" ></asp:TextBox></td>
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
        
    </div>
        
    </form>
            <a href="Register.aspx">Register here</a>
        <br />
            <a href="Default.aspx">Back to home</a>
        </div>
    
</body>
</html>

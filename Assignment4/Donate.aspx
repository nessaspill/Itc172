<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donate</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <div class="wrap">
    <h2>Make your donation here</h2>
    <form id="form1" runat="server">
    <div>
    <p class="donation">Your donation</p>
    <p>
        <asp:TextBox ID="DonationTextBox" runat="server" Height="23px" Width="214px"></asp:TextBox></p>
    <p>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" style="height: 26px" /></p>
    </div>
    </form>
        </div>
</body>
</html>

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
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Use numbers" 
            ControlToValidate="DonationTextBox">
        </asp:RequiredFieldValidator></p>
    <p>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" style="height: 26px" /></p>
    <p>
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></p>     
    </div>
    </form>
        <a href="DonationList.aspx">See your Donations</a>
        <br />
        <a href="Actions.aspx">Back to actions</a>
        &nbsp;
        <a href="Default.aspx">Back to home</a>
        </div>
</body>
</html>

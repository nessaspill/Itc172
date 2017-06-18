<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplyGrant.aspx.cs" Inherits="ApplyGrant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grant Application</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="wrap">
    <form id="form1" runat="server">
    <div>
    <h2>Apply for a grant</h2>
 <table id="grantapp">
        
        <tr>
            <td class="hLabel">Grant Type Number</td>
            <td>
                <asp:TextBox ID="GrantTypeTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator4" 
                runat="server" 
                ErrorMessage="Grant type is required." 
                ControlToValidate="GrantTypeTextBox"></asp:RequiredFieldValidator>
        </td>
        </tr>
        <tr>
            <td class="hLabel">Amount Resquested</td>
            <td><asp:TextBox ID="AmountReqTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator5" 
                runat="server" 
                ErrorMessage="Amount is required." 
                ControlToValidate="AmountReqTextBox"></asp:RequiredFieldValidator>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="hLabel">Explanation</td>
            <td>
                <asp:TextBox ID="ExplanationTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator6" 
                runat="server" 
                ErrorMessage="Explanation is required." 
                ControlToValidate="ExplanationTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Apply" OnClick="SubmitButton_Click" /></td>
            <td>
                <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        
    </table>  
        
    </div>
    </form>
        <a href="GrantView.aspx">See your Grants</a>
        <br />
        <a href="Actions.aspx">Back to actions</a>
        &nbsp;
        <a href="Default.aspx">Back to home</a>
    </div>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
      <div class="wrap">
    <form id="form1" runat="server">
    <div>
        <h2>Register Here</h2>
    <table id="registration">
        
        <tr>
            <td class="hLabel">First Name</td>
            <td>
                <asp:TextBox ID="FirstNameTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox>
            </td>
            <td></td>
            </tr>
            <tr>
            <td class="hLabel">Last Name</td>
            <td>
                <asp:TextBox ID="LastNameTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator 
                ID="RequiredFieldValidator2" 
                runat="server" 
                ErrorMessage="Last Name is required."
                 ControlToValidate="LastNameTextBox"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="hLabel">Email</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator 
                ID="RequiredFieldValidator3" 
                runat="server" 
                ErrorMessage="Email is required."
                ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator1" 
                    runat="server" 
                    ErrorMessage="Invalid email." 
                    ControlToValidate="EmailTextBox" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        </tr>
        <tr>
            <td class="hLabel">Password</td>
            <td>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Width="250px" Height="23px"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator4" 
                runat="server" 
                ErrorMessage="Password is required." 
                ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
        </td>
        </tr>
        <tr>
            <td class="hLabel">Confirm Password</td>
            <td><asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator5" 
                runat="server" 
                ErrorMessage="Password confirmation is required." 
                ControlToValidate="ConfirmTextBox"></asp:RequiredFieldValidator>
                &nbsp;
                <asp:CompareValidator 
                    ID="CompareValidator1" 
                    runat="server" 
                    ErrorMessage="Password does not match." 
                    ControlToValidate="ConfirmTextBox" 
                    ControlToCompare="PasswordTextBox"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="hLabel">Address</td>
            <td>
                <asp:TextBox ID="AddressTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator6" 
                runat="server" 
                ErrorMessage="Address is required." 
                ControlToValidate="AddressTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="hLabel">Ap Number</td>
            <td>
                <asp:TextBox ID="ApNumTextBox" runat="server" Width="251px" Height="23px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td class="hLabel">City</td>
            <td>
                <asp:TextBox ID="CityTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td class="hLabel">State</td>
            <td>
                <asp:TextBox ID="StateTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td class="hLabel">Zip Code</td>
            <td>
                <asp:TextBox ID="ZipCodeTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator7" 
                runat="server" 
                ErrorMessage="Zip Code is required." 
                ControlToValidate="ZipcodeTextBox"></asp:RequiredFieldValidator>
                &nbsp;
                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator2" 
                    runat="server" 
                    ErrorMessage="Just numbers"
                    ControlToValidate="ZipCodeTextBox" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="hLabel">Home Phone</td>
            <td>
                <asp:TextBox ID="HmPhoneTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator3" 
                    runat="server" 
                    ErrorMessage="Just numbers"
                     ControlToValidate="HmPhoneTextBox" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>

            </td>

            </tr>
        <tr>
            <td class="hLabel">Work Phone</td>
            <td>
                <asp:TextBox ID="WkPhoneTextBox" runat="server" Width="250px" Height="23px"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator4" 
                    runat="server" 
                    ErrorMessage="Just numbers"
                     ControlToValidate="WkPhoneTextBox" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Register" OnClick="SubmitButton_Click" /></td>
            <td>
                <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label></td>
            
        </tr>
        
    </table>
        
    </div>
    </form>
          <a href="Default.aspx">Back to home</a>
        </div>
    
</body>
</html>

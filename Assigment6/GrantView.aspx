<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GrantView.aspx.cs" Inherits="GrantView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grants</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="wrap">
    <form id="form1" runat="server">
    <div>
        <h3>Here are your grants</h3>
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>

        
    </div>
        <br />
        <a href="Actions.aspx">Back to actions</a>
        &nbsp;
        <a href="Default.aspx">Back to home</a>
    </form>
    </div>
</body>
</html>

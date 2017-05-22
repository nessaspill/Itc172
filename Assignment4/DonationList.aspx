<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonationList.aspx.cs" Inherits="DonationList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donation List</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <div class="wrap">
    <form id="form1" runat="server">
        
    <div>
        <h3>Here is the list of your donations</h3>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    </form>
        </div>
</body>
</html>

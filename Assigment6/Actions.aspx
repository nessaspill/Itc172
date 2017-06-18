<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Actions.aspx.cs" Inherits="Actions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Actions</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="wrap">
        
    <form id="form1" runat="server">
    <div>
        
        <h2>Choose what you want to do</h2>

        <h3><a href="Donate.aspx">Donate</a>
        <br /></h3>
        <h3><a href="DonationList.aspx">See your Donations</a>
        <br /></h3>
        <h3><a href="ApplyGrant.aspx">Apply for a grant</a>
        <br /></h3>
        <h3><a href="GrantView.aspx">See your grants</a></h3>
        <br />
        <a href="Default.aspx">Back to home</a>
    </div>
    </form>
    </div>
</body>
</html>

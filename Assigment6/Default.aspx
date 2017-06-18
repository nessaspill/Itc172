<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="wrap">
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to our community wesite!</h1>

        <h3>Here you can get some grants, if you need them.</h3>
        <h3>You also can donate to our cause.</h3>
        <h4><a href="Register.aspx">Register here</a>
        </h4>
        <h4><a href="Login.aspx">Log in here</a>
        <h4><a href="Actions.aspx">See actions here</a>
        <br /><br /></h4>
        <h2 class="title">Event Calendar</h2>
        <h3>If you want to see all our events click in the dates</h3>
        <asp:Calendar ID="EventCalendar" runat="server" OnDayRender="EventCalendar_DayRender" OnSelectionChanged="EventCalendar_SelectionChanged" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <h3><asp:Label ID="LabelCalendar1" runat="server" Text=""></asp:Label></h3>
        <p><asp:Label ID="LabelEvent" runat="server" Text=""></asp:Label></p>
    </div>
    </form>
    </div>
</body>
</html>

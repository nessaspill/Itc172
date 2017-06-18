using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Community_AssRef.Community_AssistServiceClient db =
            new Community_AssRef.Community_AssistServiceClient();
        int key = db.Login(EmailTextBox.Text, PasswordTextBox.Text);
        if (key != 0)
        {
            Session["userKey"] = key;
            Response.Redirect("Actions.aspx");
        }
        else
        {
            ResultLabel.Text = "Invalid Login";
        }
    }
}
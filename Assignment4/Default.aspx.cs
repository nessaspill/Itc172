using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        int key = 0;
        Community_AssistEntities db = new Community_AssistEntities();
        int success = db.usp_Login(UserEmailTextBox.Text, PasswordTextBox.Text);
        if (success != -1)
        {
            var uKey = (from k in db.People
                        where k.PersonEmail.Equals(UserEmailTextBox.Text)
                        select k.PersonKey).FirstOrDefault();
            key = (int)uKey;
            Session["userKey"] = key;
            Response.Redirect("Donate.aspx");
        }
        else
        {
            ResultLabel.Text = "Invalid Login";
        }
    }
}
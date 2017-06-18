using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {

        Community_AssRef.Community_AssistServiceClient db =
            new Community_AssRef.Community_AssistServiceClient();

        Community_AssRef.Donation d = new Community_AssRef.Donation();
        int key = (int)Session["userkey"];
        
            d.DonationAmount = Decimal.Parse(DonationTextBox.Text);
            d.DonationDate = DateTime.Now;
            d.PersonKey = (int)Session["userKey"];

            db.Donate(d);


        ResultLabel.Text = "Your donation was regitered with success";

    }
}
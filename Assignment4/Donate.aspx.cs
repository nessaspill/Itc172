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
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        Community_AssistEntities db = new Community_AssistEntities();
        Donation d = new Donation();
        d.DonationAmount = Decimal.Parse(DonationTextBox.Text);
        d.DonationDate = DateTime.Now;
        d.PersonKey = (int)Session["userKey"];

        db.Donations.Add(d);
        db.SaveChanges();

        Response.Redirect("DonationList.aspx");

    }
}
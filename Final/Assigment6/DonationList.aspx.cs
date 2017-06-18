using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userKey"] != null) {
            Community_AssRef.Community_AssistServiceClient db =
            new Community_AssRef.Community_AssistServiceClient();
            int key = (int)Session["userKey"];
            
            var viewDonation = db.GetDonations(key);

            GridView1.DataSource = viewDonation;
            GridView1.DataBind();

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}
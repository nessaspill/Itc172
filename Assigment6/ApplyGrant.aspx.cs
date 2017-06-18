using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplyGrant : System.Web.UI.Page
{
    Community_AssRef.Community_AssistServiceClient db =
            new Community_AssRef.Community_AssistServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userkey"] == null)
            Response.Redirect("Login.aspx");
    }



    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        int key = (int)Session["userkey"];
        Community_AssRef.GrantRequest gr = new Community_AssRef.GrantRequest();
        gr.GrantRequestDate = DateTime.Now;
        gr.GrantRequestExplanation = ExplanationTextBox.Text;
        gr.GrantRequestAmount = decimal.Parse(AmountReqTextBox.Text);
        gr.GrantTypeKey = int.Parse(GrantTypeTextBox.Text);
        gr.PersonKey = (int)Session["userKey"]; ;
        bool result = db.RequestGrant(gr);
        if (result)
            ResultLabel.Text = "Grant Submitted";
        else
            ResultLabel.Text = "There was a problem";
    }
}

    


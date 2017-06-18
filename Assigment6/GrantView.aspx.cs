using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GrantView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] != null)
        {
            Community_AssRef.Community_AssistServiceClient db =
             new Community_AssRef.Community_AssistServiceClient();
            int key = (int)Session["userkey"];
            var viewGrant = db.GetGrants(key);
            GridView2.DataSource = viewGrant;
            GridView2.DataBind();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}
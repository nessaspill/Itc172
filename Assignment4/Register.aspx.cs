using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        
        string first = FirstNameTextBox.Text;
        string last = LastNameTextBox.Text;
        string email = EmailTextBox.Text;
        string password = ConfirmTextBox.Text;
        string address = AddressTextBox.Text;
        string aptNumber = ApNumTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zipcode = ZipCodeTextBox.Text;
        string homePhone = HmPhoneTextBox.Text;
        string workPhone = WkPhoneTextBox.Text;

        Community_AssistEntities db = new Community_AssistEntities();
        int result = db.usp_Register(first, last, email, password, address, aptNumber, city, state, zipcode, homePhone, workPhone);
        if (result != -1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Something went terribly worng";
        }
    }
}
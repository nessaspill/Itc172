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

        Community_AssRef.Community_AssistServiceClient db =
            new Community_AssRef.Community_AssistServiceClient();

        Community_AssRef.PersonInfo p = new Community_AssRef.PersonInfo();
        p.Email = email;
        p.FirstName = first;
        p.LastName = last;
        p.Password = password;
        p.ApartmentNumber = aptNumber;
        p.Street = address;
        p.City = city;
        p.State = state;
        p.Zipcode = zipcode;
        p.HomePhone = homePhone;
        p.WorkPhone = workPhone;

        bool result = db.RegisterPerson(p);
        if (result)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            ErrorLabel.Text = "Review your information";
        }
    }
}
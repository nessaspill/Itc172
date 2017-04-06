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
        if (!IsPostBack)/*to the browser remember my choises when reload*/
        {
            string[] percents = { "10%", "15%", "20%", "Other" };
            TipPercentsRadioButtonList.DataSource = percents;
            TipPercentsRadioButtonList.DataBind();
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetTotals();
    }

    private void GetTotals()
    {
        //double amount = double.Parse(MealTextBox.Text);
        double amount;
        Tips tip = null;
        bool goodAmount = double.TryParse(MealTextBox.Text, out amount);
        /*if return a value false it doesn't show it*/
        if (goodAmount)
        {
            double percent = 0;
            if(TipPercentsRadioButtonList.SelectedItem.Text != "Other")
            {
                if (TipPercentsRadioButtonList.SelectedItem.Text.Equals("10%"))
                    percent = .1;
                if (TipPercentsRadioButtonList.SelectedItem.Text.Equals("15%"))
                    percent = .15;
                if (TipPercentsRadioButtonList.SelectedItem.Text.Equals("20%"))
                    percent = .2;
            }
            else
            {
                percent = double.Parse(OtherTextBox.Text);
                percent /= 100; //percent = percent / 100;
            }
            tip = new Tips(amount, percent);
        }
        else
        {
            Response.Write("<script>alert('Enter a valid amount');</script>"); //response.write=echo
        }

        ResultLabel.Text = "Amount: " + amount.ToString("$ #,##0.00") + "<br />"
            + "Tax: " + tip.CalculateTax().ToString("$ #,##0.00") + "<br />"
            + "Tip: " + tip.CalculateTip().ToString("$ #,##0.00") + "<br />"
            + "Total: " + tip.Total().ToString("$ #,##0.00");
    }
}
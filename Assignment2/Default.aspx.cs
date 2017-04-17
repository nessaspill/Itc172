using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] events = new string[6, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
        events[0, 0] = "2017-04-20";
        events[0, 1] = "The Grapes of Wrath";
        events[1, 0] = "2017-04-21";
        events[1, 1] = "The Martian Chronicles";
        events[2, 0] = "2017-04-10";
        events[2, 1] = "I Robot";
        events[3, 0] = "2017-04-10";
        events[3, 1] = "The Hobbit";
        events[4, 0] = "2017-04-30";
        events[4, 1] = "Something Wicked This Way Comes";
        events[5, 0] = "2017-04-03";
        events[5, 1] = "Something Wicked This Way Comes";

    }

    protected void EventCalendar_DayRender(object sender, DayRenderEventArgs e)
    {
        for (int i = 0; i < 6; i++)
        {
            if (e.Day.Date == DateTime.Parse(events[i, 0]))
            {
                e.Cell.ForeColor = System.Drawing.Color.DarkRed;
                e.Cell.Style.Add(HtmlTextWriterStyle.FontWeight, "bold");
            }
        }
    }

    protected void EventCalendar_SelectionChanged(object sender, EventArgs e)
    {
        LabelEvent.Text = "";
        string eventDate;
       // bool found = false;
        eventDate = EventCalendar.SelectedDate.ToString("yyyy-MM-dd");
        LabelCalendar1.Text = "Events in " + EventCalendar.SelectedDate.ToShortDateString();
        for (int i = 0; i < 6; i++)
        {
            if (events[i, 0].Equals(eventDate))
            {
                LabelEvent.Text += events[i, 1] + "<br />";
               // found = true;
            }
        }

        //if(!found){}
        if (LabelEvent.Text == "") {
            LabelEvent.Text += "There are no events in this date.";
        }
    }
}


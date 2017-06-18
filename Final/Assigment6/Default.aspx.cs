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
        events[0, 0] = "2017-07-20";
        events[0, 1] = "Lecture: How to Use your money well";
        events[1, 0] = "2017-07-21";
        events[1, 1] = "Meeting: Organization of a Found Raiser";
        events[2, 0] = "2017-07-10";
        events[2, 1] = "Help Day: Come get help to apply for grants";
        events[3, 0] = "2017-07-10";
        events[3, 1] = "Meeting: Organization of a Found Raiser";
        events[4, 0] = "2017-06-30";
        events[4, 1] = "Lecture: How to live in your budge";
        events[5, 0] = "2017-07-03";
        events[5, 1] = "Case of success: Presentation of the cases of success";
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
        if (LabelEvent.Text == "")
        {
            LabelEvent.Text += "There are no events in this date.";
        }
    }
}
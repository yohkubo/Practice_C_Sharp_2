using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }

        protected void setButton_Click(object sender, EventArgs e)
        {
            myCalendar.SelectedDate = DateTime.Parse("10/31/2017");
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            myCalendar.VisibleDate = DateTime.Parse("8/25/2016");
        }

        protected void selectedWeekButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Week of" + myCalendar.SelectedDate.ToShortDateString();
        }

        protected void myCalendar_SelectionChanged(object sender, EventArgs e)
        {
            resultLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }
    }
}
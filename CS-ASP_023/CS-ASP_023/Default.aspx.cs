using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_023
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);

            }
        }

        protected void addHourButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];

            Array.Resize(ref hours, hours.Length + 1);

            int newestItem = hours.GetUpperBound(0); // OR hours.length-1

            hours[newestItem] = double.Parse(hoursTextBox.Text);

            ViewState["Hours"] = hours;

            okLabel.Text = String.Format(
                                        "Total hours: {0}" +
                                        "<br />Least Hours: {1}" +
                                        "<br />Most Hours: {2}" +
                                        "<br />Average Hours: {3:N2}" +
                                        "<br />Each hours: ", // data coming from for statement 
                                        hours.Sum(),
                                        hours.Min(),
                                        hours.Max(),
                                        hours.Average()
                                        );

            for (int i = 0; i < hours.Length; i++)
            {
                okLabel.Text += String.Format("{0}, ", hours[i]);
            }

        }
    }
}
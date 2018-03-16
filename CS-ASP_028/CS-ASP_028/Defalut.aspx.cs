using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_028
{
    public partial class Defalut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
        }

        protected void pintRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
        }

        protected void quartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
        }

        protected void gallonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
        }


        private void calculateCups()
        {
            if (TextBox1.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(TextBox1.Text, out quantity))
                return;

            double cups = 0.0;
            if (cupRadioButton.Checked) cups = 1;
            if (pintRadioButton.Checked) cups = 2;
            if (quartRadioButton.Checked) cups = 4;
            if (gallonRadioButton.Checked) cups = 8;

            resultLabel.Text = "The number of cups: " + (quantity * cups).ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int i = int.Parse(firstTextBox.Text);
            int j = int.Parse(secondTextBox.Text);
            string result;

            if (i == j)
            {
                result = "Yes, it is.";
            }
            else {
                result = "No, it is not.";
            }
            resultLabel.Text = result;
        }

        protected void ok2Button_Click(object sender, EventArgs e)
        {
            if (thirdTextBox.Text == forthTextBox.Text)
            {
                result2Label.Text = "Yes, it is.";
            }
            else
            {
                result2Label.Text = "No, it is not.";
            }
        }

        protected void ok3Button_Click(object sender, EventArgs e)
        {
            if (coolCheckBox.Checked)
            {
                result3Label.Text = "Yes, you are!!";
            }
            else
            {
                result3Label.Text = "No man, don't be so hard yourself.";
            }
        }

        protected void ok4Button_Click(object sender, EventArgs e)
        {
            if (pizzaRadioButton.Checked)
            {
                result4Label.Text = "You must be from Chicago!!";
            }
            else if (saladRadioButton.Checked)
            {
                result4Label.Text = "You must be healthy!!";
            }
            else if (pbjRadioButton.Checked)
            {
                result4Label.Text = "You must be fun loving person!!";
            }
            else
            {
                result4Label.Text = "Please select one of those options.";
            }
        }


    }
}
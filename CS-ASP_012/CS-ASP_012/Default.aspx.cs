using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";
            int result = (firstTextBox.Text == secondTextBox.Text) ? 100 : 50;
            resultLabel.Text = result.ToString();

            result2Label.Text = (oldCheckBox.Checked) ? "Enjoy your rest of life!" : "Work hard!!";
        }
    }
}
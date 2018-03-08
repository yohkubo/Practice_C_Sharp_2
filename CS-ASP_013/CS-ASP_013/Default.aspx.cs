using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonTypeLabel.Text = "equal to";
            //comparisonTypeLabel.Text = "not equal to";
            comparisonTypeLabel.Text = "greater than";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yse" : "No";
            //resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";
            //resultLabel.Text = (firstTextBox.Text > secondTextBox.Text) ? "Yes" : "No";

            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);
            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first < second) ? "Yes" : "No";
            //resultLabel.Text = (first >= second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yse" : "No";

            //resultLabel.Text = (!CheckBox.Checked) ? "No" : "Yes";

            /*
            if (CheckBox.Checked 
                && firstTextBox.Text == "Bob" 
                && secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "Perfect result!!";
            }
            */

            if ((CheckBox.Checked 
                || firstTextBox.Text == "Bob") 
                && secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "Two out of three ain't bad.";
            }


        }
    }
}
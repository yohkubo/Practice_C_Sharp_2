using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank your, {0}, for your business", nameTextBox.Text);

            int ssn = int.Parse(ssnTextBox.Text);
            //string result = String.Format("Thank you, {0}, for your business. <br />Your Social Security Number is: {1:000-00-0000}", nameTextBox.Text, ssn);

            int phone = int.Parse(phoneTextBox.Text);
            //string result = String.Format("Thank you, {0}, for your business.<br /> " +
            //                            "Your Social Security Number is: {1:000-00-0000}<br />" +
            //                            "Phone number: {2:000(000)0000}", nameTextBox.Text, ssn, phone);

            /*
            string result = String.Format("Thank you, {0}, for your business." +
                "<br />Your Social Security Number: {1:111-11-1111}" +
                "<br />Phone Number: {2:000(000)0000}" +
                "<br />Loan Date: {3:MMM-dd(ddd), yyyy}", 
                nameTextBox.Text,
                ssn,
                phone,
                myCalendar.SelectedDate);
            */


            resultLabel.Text = result;

        }
    }
}
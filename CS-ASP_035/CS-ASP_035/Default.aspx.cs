﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035
{
    public partial class Default : System.Web.UI.Page
    {
        private object resultLabal;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = "<p style=\"color:#ee3b32;\">Hi</p>";

            string value = valueTextBox.Text;

            // Access any specific charactor
            //resultLabel.Text = value[3].ToString();
            // StartWIth(), EndWith(, Contains

            /*
            if (value.StartsWith("A"))
                resultLabel.Text = "Value start with 'A'";

            if (value.EndsWith("."))
                resultLabel.Text += "<br />Value end with '.'";

            if (value.Contains("good"))
                resultLabel.Text += "<br />Value contains 'good'";
                */

            // IndexOf()
            int index = value.IndexOf("good");
            //resultLabel.Text = "'good' begins at index " + index.ToString();

            // Insert, Remove
            //resultLabel.Text = value.Insert(index, "jolly ");

            //resultLabel.Text = value.Remove(index, 3);

            // Substring
            //resultLabel.Text = value.Substring(index, value.Length - index - 1);

            // Trim, TrimStart, TrimEnd
            /*
            resultLabel.Text = String.Format("Before Trim: {0}<br />After TrimStart: {1}<br />TrimEnd: {2}<br />Trim: {3}",
                value.Length, 
                value.TrimStart().Length, 
                value.TrimEnd().Length, 
                value.Trim().Length);
            */

            // PadLeft, PadRight
            //resultLabel.Text = value.PadLeft(10, 'H');

            // ToUpper, ToLower
            //if ("Bob" == "bob") resultLabel.Text = "The same";
            //else resultLabel.Text = "different";

            /*
            if (valueTextBox.Text.Trim().ToUpper() == "BOB") resultLabel.Text = "The same";
            else resultLabel.Text = "Different";
            */

            // Replace()
            //string template = "[NAME] said it would be ok. Maybe you should take that up with [NAME]";
            //resultLabel.Text = template.Replace("[NAME]", valueTextBox.Text);

            //Split
            StringBuilder sb = new StringBuilder();
            string[] values = valueTextBox.Text.Split(',');

            for (int i = 0; i < values.Length; i++)
            {
                //resultLabel.Text += values[i] + " " + values[i].Length + "<br />";
                sb.Append(values[i]);
                sb.Append(" ");
                sb.Append(values[i].Length);
                sb.Append("<br/>");
            }

            resultLabel.Text = sb.ToString();

        }
    }
}
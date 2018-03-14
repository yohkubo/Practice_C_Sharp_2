using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_025
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            if (CheckBox1.Checked)
            {
                if (CheckBox2.Checked)
                {
                    if (CheckBox3.Checked)
                    {
                        Label1.Text = "They are all checked!!";
                    }
                    else Label1.Text = "";
                }
            }
            */

            if (!CheckBox1.Checked) return;
            if (!CheckBox2.Checked) return;
            if (!CheckBox3.Checked) return;
            Label1.Text = "They are all checked!!";





        }
    }
}
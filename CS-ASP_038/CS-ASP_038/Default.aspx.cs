using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_038
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myCar = new Car();

            myCar.Make = "Subaru";
            myCar.Model = "Legacy";
            myCar.year = 1995;
            myCar.price = 1000.0;

            Car hisCar = myCar;

            hisCar.price = 2000;

            Label1.Text = String.Format("{0}, {1}, {2}, {3}", 
                myCar.Make, myCar.Model, myCar.year, myCar.price);


        }
    }
}
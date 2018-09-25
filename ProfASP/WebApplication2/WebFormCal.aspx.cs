using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebFormCal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calculator myCalc = new Calculator();
            Label1.Text = myCalc.Add(12, 12).ToString();
        }
    }
}
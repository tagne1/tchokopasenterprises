using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.App_Code
{
    public partial class Calculator : System.Web.UI.Page
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Subtract(int a, int b)
        {
            return (a - b);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           // CCalculator myCalc = new CCalculator();
            //Label1.Text = Add(12, 12).ToString();
            Label2.Text = Subtract(30, 12).ToString();
            Console.WriteLine();
            //Label3.Text = myCalc.cAdd(12, 12).ToString();
           // Label4.Text = myCalc.cSubtract(30, 12).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Add(12, 12).ToString();
        }
    }
}
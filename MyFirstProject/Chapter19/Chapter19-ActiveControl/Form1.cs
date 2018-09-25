using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter19_ActiveControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string pdf = "http://www.interact-sw.co.uk/downloads/ExamplePdf.pdf";
            pdfAxCtl.src = pdf;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}

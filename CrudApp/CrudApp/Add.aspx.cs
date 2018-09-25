using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CrudApp
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)

        {

            //Getting connecrtion string from web.config 
            string con = ConfigurationManager.ConnectionStrings["CrudApp.Properties.Settings.ConStringToCRUD1"].ConnectionString;
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into user2 (u_fname,u_lname,u_contact,u_email) values ('" + txtFname.Text + "','" + txtLname.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Response.Write("< script > alert('Data Inserted !!') </ script >");   
            }
            else
            {
                Response.Write("< script > alert('Data Inserted !!') </ script >");   
            }
            db.Close();
        }

    }
}
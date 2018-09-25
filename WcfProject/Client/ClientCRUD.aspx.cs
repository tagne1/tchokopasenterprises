using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Data;
using WcfProject;
using Client.ServiceReference12;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Linq;

namespace Client
{
    public partial class ClientTest : System.Web.UI.Page
    {
        //Service1Client obj = new Service1Client();

        private static WebChannelFactory<ServiceReference12.IService1> cf = new WebChannelFactory<ServiceReference12.IService1>(new Uri("http://localhost:52420/ContactService.svc"));
        ServiceReference12.IService1 channel = cf.CreateChannel();

        // Will replace obj with client
        Employee1 emp = new Employee1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        public void BindData()
        {
            List<Employee1> li = new List<Employee1>();

            //li = obj.ShowAll();
            // GridView1.DataSource = li;

            //GridView1.DataSource = obj.ShowAll(); // old
            GridView1.DataSource = channel.ShowAll();// new
            GridView1.DataBind();
        }

        protected void Btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "SAVE")
            {
                Employee1 employee = new Employee1();
                emp.EmpLastName = txt_name.Text;
                emp.EmpFirstMidName = txt_FM_name.Text;
                emp.EmpEmail = txt_email.Text;
                emp.CompanyName = txt_company.Text;
                emp.Dept = txt_dept.Text;
                emp.Location1 = txt_location.Text;
                bool x = false;
                //x = obj.InsertData(emp); //old
                x = channel.InsertData(emp); //new
                if (x == true)
                {
                    Response.Write("<script LANGUAGE=\"JavaScript\" >alert('Data Inserted Successfully.')</script>");
                    Clear();
                    BindData();
                }
                else
                {
                    Response.Write("<script LANGUAGE=\"JavaScript\" >alert('Please try again.')</script>");
                }
            }
            else
            {
                Employee1 employee = new Employee1();
                emp.EmpLastName = txt_name.Text;
                emp.EmpFirstMidName = txt_FM_name.Text;
                emp.EmpEmail = txt_email.Text;
                emp.CompanyName = txt_company.Text;
                emp.Dept = txt_dept.Text;
                emp.Location1 = txt_location.Text;
                emp.EmpId = Convert.ToInt32(lbl_id.Text);
                bool x = false;
                //x = obj.UpdateData(emp); //old
                x = channel.UpdateData(emp); // new
                if (x == true)
                {
                    Response.Write("<script LANGUAGE=\"JavaScript\" >alert('Data Updated Successfully.')</script>");
                    btn_save.Text = "SAVE";
                    GridView1.EditIndex = -1;
                    Clear();
                    BindData();
                }
                else
                {
                    Response.Write("<script LANGUAGE=\"JavaScript\" >alert('Please try again.')</script>");
                }
            }
        }
        public void Clear()
        {
            txt_company.Text = "";
            txt_FM_name.Text = "";
            txt_email.Text = "";
            txt_dept.Text = "";
            txt_location.Text = "";
            txt_name.Text = "";
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            List<Employee1> li = new List<Employee1>();
            Label lbl = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbl_empid");
            int userId = Convert.ToInt32(lbl.Text);
            DataTable dt = new DataTable();
            //li = obj.GetRecordbyId(userId);
            foreach (var x in channel.GetRecordbyId(userId)) // I replaced li with obj.GetRecordbyId(userId) and used client instead of obj
            {
                txt_company.Text = x.CompanyName;
                txt_dept.Text = x.Dept;
                txt_location.Text = x.Location1;
                txt_FM_name.Text = x.EmpFirstMidName;
                txt_email.Text = x.EmpEmail;
                txt_name.Text = x.EmpLastName;
                lbl_id.Text = (x.EmpId).ToString();
                btn_save.Text = "UPDATE";
                BindData();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbl_delID = (Label)GridView1.Rows[e.RowIndex].FindControl("lbl_empid");
            Employee1 obj1 = new Employee1
            {
                EmpId = Convert.ToInt32(lbl_delID.Text)
            };
            //bool m = obj.DeleteData(obj1); // old
            bool m = channel.DeleteData(obj1); // new
            if (m == true)
            {
                Response.Write("<script LANGUAGE=\"JavaScript\" >alert('Data Deleted')</script>");
            }
            else
            {
                Response.Write("<script LANGUAGE=\"JavaScript\" >alert('Please try again.')</script>");
            }

            BindData();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel.Activation;

namespace WcfProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        private WcfDAL myobject = new WcfDAL();

        public bool InsertData(Employee1 obj)
        {
            string query = "insert into Employee(EmpLastName,EmpFirstMidName,EmpEmail,CompanyName,Location1,Dept) values('" + obj.EmpLastName + "','" + obj.EmpFirstMidName + "','" + obj.EmpEmail + "','" + obj.CompanyName + "','" + obj.Location1 + "','" + obj.Dept + "')";
            bool x = myobject.DML(query);
            return x;
        }
        public bool UpdateData(Employee1 obj)
        {
            string query = "update Employee set EmpLastName='" + obj.EmpLastName + "',EmpFirstMidName='" + obj.EmpFirstMidName + "',EmpEmail='" + obj.EmpEmail + "',CompanyName='" + obj.CompanyName + "',Location1='" + obj.Location1 + "',Dept='" + obj.Dept + "' where EmpId='" + obj.EmpId + "' ";
            bool x = myobject.DML(query);
            return x;
        }
        public bool DeleteData(Employee1 obj)
        {
            string query = "Delete from Employee where EmpId='" + obj.EmpId + "'";
            bool x = myobject.DML(query);
            return x;
        }

        public List<Employee1> ShowAll()
        {
            List<Employee1> li = new List<Employee1>();
            string s = "select * from Employee";
            DataTable dt = new DataTable();
            dt = myobject.Getdata(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Employee1 emp = new Employee1
                {
                    EmpId = Convert.ToInt32(dt.Rows[i]["EmpId"]),
                    EmpLastName = dt.Rows[i]["EmpLastName"].ToString(),
                    EmpFirstMidName = dt.Rows[i]["EmpFirstMidName"].ToString(),
                    EmpEmail = dt.Rows[i]["EmpEmail"].ToString(),
                    CompanyName = dt.Rows[i]["CompanyName"].ToString(),
                    Location1 = dt.Rows[i]["Location1"].ToString(),
                    Dept = dt.Rows[i]["Dept"].ToString()
                };

                li.Add(emp);

            }

            return li;

        }
        public List<Employee1> GetRecordbyId(int id)
        {
            List<Employee1> li = new List<Employee1>();
            DataTable dt1 = new DataTable();
            string query = "select * from Employee where EmpId='" + id + "'";
            dt1 = myobject.Getdata(query);
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    Employee1 emp = new Employee1
                    {
                        EmpId = Convert.ToInt32(dt1.Rows[i]["EmpId"]),
                        EmpLastName = dt1.Rows[i]["EmpLastName"].ToString(),
                        EmpFirstMidName = dt1.Rows[i]["EmpFirstMidName"].ToString(),
                        EmpEmail = dt1.Rows[i]["EmpEmail"].ToString(),
                        CompanyName = dt1.Rows[i]["CompanyName"].ToString(),
                        Location1 = dt1.Rows[i]["Location1"].ToString(),
                        Dept = dt1.Rows[i]["Dept"].ToString()
                    };

                    li.Add(emp);

                }
                return li;

            }
            else
            {
                return li;
            }

        }
    }
}

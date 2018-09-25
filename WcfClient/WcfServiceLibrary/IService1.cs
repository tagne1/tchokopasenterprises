using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool InsertData(Employee1 obj);

        [OperationContract(Name = "ShowAll")]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ShowAll")]
        List<Employee1> ShowAll();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/showdata/")]
        List<Employee1> GetRecordbyId(int id);

        [OperationContract]
        bool UpdateData(Employee1 obj);

        [OperationContract]
        bool DeleteData(Employee1 obj);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary.ContractType".
    [DataContract]
    public class Employee1
    {
        int _EmpId;
        string _Lname = "";
        string _Fname = "";
        string _Eemail = "";
        string _Cname = "";
        string _Llocation1 = "";
        string _Ddepartment = "";

        [DataMember]
        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        [DataMember]
        public string EmpLastName
        {
            get { return _Lname; }
            set { _Lname = value; }
        }

        [DataMember]
        public string EmpFirstMidName
        {
            get { return _Fname; }
            set { _Fname = value; }
        }

        [DataMember]
        public string EmpEmail
        {
            get { return _Eemail; }
            set { _Eemail = value; }
        }

        [DataMember]
        public string CompanyName
        {
            get { return _Cname; }
            set { _Cname = value; }
        }

        [DataMember]
        public string Location1
        {
            get { return _Llocation1; }
            set { _Llocation1 = value; }
        }

        [DataMember]
        public string Dept
        {
            get { return _Ddepartment; }
            set { _Ddepartment = value; }
        }
    }
}

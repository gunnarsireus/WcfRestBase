using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.EnterpriseServices;

namespace WcfRestBase
{
    [ServiceContract]
    public interface IService
    {
        [WebInvoke(Method = "GET", UriTemplate = "Get/{Id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Employee GetEmployee(string Id);

        [WebInvoke(Method = "GET", UriTemplate = "Delete/{Id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        void DeleteEmployee(string Id);

        [WebInvoke(Method = "GET", UriTemplate = "List", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Employee> GetEmployees();

        [WebInvoke(Method = "GET", UriTemplate = "Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        void AddEmployee();

        [WebInvoke(Method = "POST", UriTemplate = "Create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [OperationContract]
        void CreateEmployee(Employee employee);

        [WebInvoke(Method = "POST", UriTemplate = "Update", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [OperationContract]
        void UpdateEmployee(Employee employee);
    }
} 


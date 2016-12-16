using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WcfRestBase
{
    [CollectionDataContract(Name = "employees", Namespace = "")]
    public class Employees : List<Employee>
    { }

    [DataContract(Name = "Employee", Namespace = "")]
    public class Employee
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Gender")]
        public string Gender { get; set; }
        [DataMember(Name = "DateOfBirth")]
        public DateTime DateOfBirth { get; set; }
    }
}

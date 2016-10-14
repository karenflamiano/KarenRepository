using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeWebService
{
    [DataContract]
    public class BaseResponse
    {
        public BaseResponse()
        {
            this.ErrorList = new List<string>();
        }

        [DataMember]
        public EmployeeDetails Employee;

        [DataMember]
        public List<string> ErrorList { get; set; }

        
    }
}
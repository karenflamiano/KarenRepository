using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class RequestBase
    {
        [DataMember]
        public int EmployeeNumber { get; set; }
    }
}
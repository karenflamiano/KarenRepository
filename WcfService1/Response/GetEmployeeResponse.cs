using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using WcfService1.Response;

namespace WcfService1
{
    [DataContract]
    public class GetEmployeeResponse : BaseResponse
    {
        public string FullName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WcfService1.Response
{
    [DataContract]
    public class BaseResponse
    {
       public  BaseResponse()
        {
            this.ErrorList = new List<string>();
        }
        [DataMember]
        public List<string> ErrorList { get; set; }
    }
}
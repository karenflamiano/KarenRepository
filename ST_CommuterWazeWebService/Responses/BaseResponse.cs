using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ST_CommuterWazeWebService
{
    [DataContract]
    public class BaseResponse
    {
        public BaseResponse()
        {
            ListOfError = new List<string>();
            ListOfExceptions = new List<string>();
        }

        [DataMember]
        public List<string> ListOfError { get; set; }

        [DataMember]
        public List<string> ListOfExceptions { get; set; }
    }
}
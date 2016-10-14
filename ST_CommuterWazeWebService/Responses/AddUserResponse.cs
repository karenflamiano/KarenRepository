using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ST_CommuterWazeWebService
{
    [DataContract]
    public class AddUserResponse:BaseResponse
    {
        [DataMember]
        public int Result { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ST_CommuterWazeWebService
{
    [DataContract]
    public class RetrieveUserRequest
    {
        [DataMember]
        public string Username { get; set; }
    }
}
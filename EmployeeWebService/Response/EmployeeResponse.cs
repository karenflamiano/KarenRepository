﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeWebService
{
    [DataContract]
    public class EmployeeResponse : BaseResponse
    {
        [DataMember]
        public bool Status { get; set; }
    }
}
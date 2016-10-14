﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ST_CommuterWazeWebService
{
    [DataContract]
    public class RetrievePreferredRouteResponse
    {
        public RetrievePreferredRouteResponse()
        {
            ListOfPreferredRouteEntity = new List<PreferredRouteEntity>();
        }
        [DataMember]
        public List<PreferredRouteEntity> ListOfPreferredRouteEntity;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ST_CommuterWazeWebService
{
    public class RouteEntity
    {
        public int RouteID { get; set; }
        public string Route { get; set; }
        public string VehicleType { get; set; }
        public double Fare { get; set; }
    }
}
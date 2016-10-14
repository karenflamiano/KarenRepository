using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ST_CommuterWazeWebService
{
    public class UserEntity
    {
        public string Username { get; set; }
        public string Salt { get; set; }
        public string HashPassword { get; set; }
    }
}
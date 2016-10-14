using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ST_CommuterWazeWebService
{
    public static class Utility
    {
        public static byte[] GetBytes(string message)
        {
            return Encoding.ASCII.GetBytes(message);
        }

        public static string GetString(byte[] resultBytes)
        {
            return Encoding.ASCII.GetString(resultBytes);
        }
    }
}
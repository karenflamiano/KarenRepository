using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _4Inputs
{
    /// <summary>
    /// Summary description for _4InputsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _4InputsService : System.Web.Services.WebService
    {
        [WebMethod]
        public int AddFourInputs(int input1, int input2, int input3, int input4)
        {
            int sum = (input1 + input2 + input3 + input4);
            return sum;
        }

        [WebMethod]
        public int AverageFourInputs(int input1, int input2, int input3, int input4)
        {
            int ave = (input1 + input2 + input3 + input4)/4;
            return ave;
        }


        [WebMethod]
        public int[] SwapFourInputs(int input1, int input2, int input3, int input4)
        {
            int[] numberArray = { input1, input2, input3, input4};

            int pos1 = numberArray[0];
            numberArray[0] = numberArray[1];
            numberArray[1] = pos1;

            int pos3 = numberArray[2];
            numberArray[2] = numberArray[3];
            numberArray[3] = pos3;

            return numberArray;
            
        }
    }
}

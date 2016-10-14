using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient ws = new WebService1SoapClient();
            ws.Add(1, 20);

        }
    }
}

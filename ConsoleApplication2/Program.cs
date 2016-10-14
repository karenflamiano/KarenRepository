using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.ServiceReference1;
using WcfService1;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client svc = new Service1Client();

            GetEmployeeRequest request = new GetEmployeeRequest()
            {
                FirstName = "Batch",
                LastName = "Chuga"
            };

            GetEmployeeResponse response = new GetEmployeeResponse();
            response = svc.GetEmployee(request);
            
            if(response.ErrorList.Count > 0)
            {
                Console.WriteLine(response.ErrorList[0]);
                Console.ReadLine();
                return;
            }

            Console.WriteLine(response.FullName);
            Console.ReadLine();
        }
    }
}

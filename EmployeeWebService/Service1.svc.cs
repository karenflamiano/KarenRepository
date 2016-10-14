using EmployeeWebService.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        [DataMember]
        public ServiceManager manager = new ServiceManager();

        public EmployeeResponse CreateEmployee(EmployeeRequest request)
        {
            return (manager.AddEmployeeToDB(request));
        }

        public EmployeeResponse DeleteEmployee(EmployeeRequest request)
        {
            return (manager.DeleteEmployeeFromDB(request));
        }

        public List<EmployeeResponse> ReadAllEmployee()
        {
            return (manager.ReadAllEmployeeFromDB());
        }

        public EmployeeResponse ReadSpecificEmployee(EmployeeRequest request)
        {
            return (manager.ReadSpecificEmployeeFromDB(request));
        }

        public EmployeeResponse UpdateEmployee(EmployeeRequest request)
        {
            return (manager.EditEmployeeFromDB(request));
        }
    }
}

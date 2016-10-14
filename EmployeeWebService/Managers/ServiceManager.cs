using EmployeeEF;
using EmployeeEF.BusinessLogic;
using EmployeeWebService.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebService
{
    public class ServiceManager
    {
        EmployeeBL bLogic = new EmployeeBL();
        public EmployeeResponse AddEmployeeToDB(EmployeeRequest request)
        {
            var returnVal = bLogic.AddEmployeeToDB(Mapper.toTable(request));

            return new EmployeeResponse()
            {
                Status = returnVal
            };
        }

        public EmployeeResponse EditEmployeeFromDB(EmployeeRequest request)
        {
            var returnVal = bLogic.EditEmployeeFromDB(Mapper.toTable(request));

            return new EmployeeResponse()
            {
                Status = returnVal
            };
        }

        public EmployeeResponse DeleteEmployeeFromDB(EmployeeRequest request)
        {
            var returnVal = bLogic.DeleteEmployeeFromDB(Mapper.toTable(request));

            return new EmployeeResponse()
            {
                Status = returnVal
            };
        }

        public List<EmployeeResponse> ReadAllEmployeeFromDB()
        {
            var returnVal = bLogic.ReadAllEmployees();

            List<EmployeeResponse> employeeList = new List<EmployeeResponse>();

            foreach (var item in returnVal)
            {
                employeeList.Add(Mapper.toEmployeeResponse(item));
            }

            return employeeList;
        }

        public EmployeeResponse ReadSpecificEmployeeFromDB(EmployeeRequest request)
        {
            var returnVal = bLogic.ReadSpecificEmployee(request.EmployeeID);

            return Mapper.toEmployeeResponse(returnVal);
        }

        public EmployeeResponse EmployeeExists(EmployeeRequest request)
        {
            return new EmployeeResponse() {
                Status = bLogic.EmployeeExists(request.EmployeeID)
            }; 
        }

    }
}
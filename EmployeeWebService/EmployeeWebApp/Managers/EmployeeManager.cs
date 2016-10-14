using EmployeeWebApp.EmployeeService;
using EmployeeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Managers
{
    public class EmployeeManager
    {
        Service1Client service = new Service1Client();
        
        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> empList = new List<EmployeeModel>();

            foreach (var item in service.ReadAllEmployee().ToList())
            {
                empList.Add(Mapper.toModel(item));
            }
            return empList;
        }

        public EmployeeModel GetSpecificEmployee(int ID)
        {
            EmployeeModel emp = Mapper.toModel(service.ReadSpecificEmployee(new EmployeeRequest()
            {
                EmployeeID = ID
            }));
            return emp;
        }

        public bool AddNewEmployee(EmployeeModel model)
        {
            EmployeeResponse response = service.CreateEmployee(Mapper.toEmployeeRequest(model));
            return response.Status;
        }

        public bool UpdateEmployee(EmployeeModel model)
        {
            EmployeeResponse response = service.UpdateEmployee(Mapper.toEmployeeRequest(model));
            return response.Status;
        }

        public bool DeleteEmployee(EmployeeModel model)
        {
            EmployeeResponse response = service.DeleteEmployee(Mapper.toEmployeeRequest(model));
            return response.Status;
        }

        public bool CheckIfEmployeeExists(int ID)
        {
            if(GetAllEmployees().Any(x=>x.EmployeeID == ID))
            {
                return true;
            }
            return false;
        }
    }
}
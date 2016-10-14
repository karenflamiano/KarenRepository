using EmployeeEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebService.Managers
{
    public static class Mapper
    {
        public static TblEmployee toTable(EmployeeRequest request)
        {
            return new TblEmployee()
            {
                EmployeeID = request.EmployeeID,
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                BirthDate = request.Birthday,
                Email = request.Email
            };
        }

        public static TblEmployee toTable(EmployeeResponse request)
        {
            return new TblEmployee()
            {
                EmployeeID = request.Employee.EmployeeID,
                FirstName = request.Employee.FirstName,
                MiddleName = request.Employee.MiddleName,
                LastName = request.Employee.LastName,
                BirthDate = request.Employee.Birthday,
                Email = request.Employee.Email
            };
        }

        public static EmployeeResponse toEmployeeResponse(TblEmployee employee)
        {
            return new EmployeeResponse()
            {
                Employee = new EmployeeDetails()
                {
                    EmployeeID = employee.EmployeeID,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    Birthday = employee.BirthDate,
                    Email = employee.Email
                },
                Status = false
            };
        }

        public static EmployeeRequest toEmployeeRequest(TblEmployee employee)
        {
            return new EmployeeRequest()
            {
                EmployeeID = employee.EmployeeID,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                Birthday = employee.BirthDate,
                Email = employee.Email
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Models
{
    public class EmployeeViewModel
    {
        public IEnumerable<EmployeeModel> employeeList { get; set; }
        public EmployeeModel currentEmployee { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEF.Entities
{
    class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }
    }
}

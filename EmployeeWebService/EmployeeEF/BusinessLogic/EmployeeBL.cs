using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEF.BusinessLogic
{
    public class EmployeeBL
    {
        List<Exception> errorLogs = new List<Exception>();

        public bool AddEmployeeToDB(TblEmployee employee)
        {
            try
            {
                using (var context = new EMPLOYEEDBEntities())
                {
                    context.TblEmployees.Add(employee);
                    return context.SaveChanges() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return false;
            }

        }

        public bool EditEmployeeFromDB(TblEmployee employee)
        {
            try
            {
                using (var context = new EMPLOYEEDBEntities())
                {
                    context.Entry(employee).State = EntityState.Modified;
                    return context.SaveChanges() > 0 ? true : false;
                }
            }

            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return false;
            }
        }

        public bool DeleteEmployeeFromDB(TblEmployee employee)
        {
            try
            {
                using (var context = new EMPLOYEEDBEntities())
                {
                    context.Entry(employee).State = EntityState.Deleted;
                    return context.SaveChanges() > 0 ? true : false;
                }
            }

            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return false;
            }
        }

        public TblEmployee ReadSpecificEmployee(int id)
        {
            try
            {
                using (var context = new EMPLOYEEDBEntities())
                {
                    return context.TblEmployees.Where(x => x.EmployeeID == id).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return null;
            }
        }

        public List<TblEmployee> ReadAllEmployees()
        {
            try
            {
                using (var context = new EMPLOYEEDBEntities())
                {
                    return context.TblEmployees.ToList();
                }
            }
            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return null;
            }
        }

        public bool EmployeeExists(int id)
        {
            try
            {
                using (var context = new EMPLOYEEDBEntities())
                {
                    return context.TblEmployees.Any(x => x.EmployeeID == id);
                }
            }
            catch (Exception ex)
            {
                errorLogs.Add(ex);
                return false;
            }
        }
    }
}
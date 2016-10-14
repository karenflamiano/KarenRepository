using EmployeeWebApp.Managers;
using EmployeeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager manager = new EmployeeManager();
        static EmployeeViewModel employeeViewModel = new EmployeeViewModel();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeView()
        {
            employeeViewModel.employeeList = manager.GetAllEmployees();
            employeeViewModel.currentEmployee = new EmployeeModel();
            return View(employeeViewModel);
        }

        public void AddEmployee()
        {
            employeeViewModel.currentEmployee = new EmployeeModel();
        }

        public JsonResult SaveEmployee(EmployeeModel model)
        {
            model.EmployeeID = employeeViewModel.currentEmployee.EmployeeID;
            if (manager.CheckIfEmployeeExists(model.EmployeeID))
            {
                manager.UpdateEmployee(model);
            }
            else
            {
                manager.AddNewEmployee(model);
            }
            return Json(new { Status = model }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SelectEmployee(string EmployeeID)
        {
            int ID = 0;
            Int32.TryParse(EmployeeID, out ID);
            var model = new EmployeeModel();

            if (manager.CheckIfEmployeeExists(ID))
            {
                model = manager.GetSpecificEmployee(ID);
                employeeViewModel.currentEmployee = model;
            }
            return Json(new { Status = model }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteEmployee(string EmployeeID)
        {
            int ID = 0;
            var returnVal = false;
            Int32.TryParse(EmployeeID, out ID);
            var model = new EmployeeModel()
            {
                EmployeeID = ID
            };

            if (manager.CheckIfEmployeeExists(ID))
            {
                returnVal = manager.DeleteEmployee(model);
                employeeViewModel.currentEmployee = new EmployeeModel();
            }
            return Json(new { Status = returnVal }, JsonRequestBehavior.AllowGet);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFExercise.Models;
using WCFExercise.ServiceReference2;
using WebService;
using WebService.Response;

namespace WCFExercise.Controllers
{
    public class ConversionController : Controller
    {
        BMIManager manager = new BMIManager();

        // GET: Conversion
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ConverterView()
        {
            return View();
        }
        
        public JsonResult ConverterWeight(double weight, string weightUnit)
        {
            var finalWeight = manager.getWeight(weight, weightUnit);
            return Json( new { finalWeight = finalWeight.weight, finalUnit = finalWeight.type }, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult ConvertHeight(double height, string heightUnit)
        {
            var finalHeight = manager.getHeight(height, heightUnit);
            return Json(new { finalHeight = finalHeight.height, finalUnit = finalHeight.type }, JsonRequestBehavior.AllowGet );

        }

        public JsonResult ConvertBmi(double checkHeight, double checkWeight)
        {
            var computeBMI = manager.getBMI(checkWeight,checkHeight);
            return Json(new { computeBMI = computeBMI.BMI, statusBMI = computeBMI.BMIstatus }, JsonRequestBehavior.AllowGet );
            
        }
        
    }
}
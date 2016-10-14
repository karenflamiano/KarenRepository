using LocalReportDemo.Entities;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalReportDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Export()
        {
            ReportViewer mainReportViewer = new ReportViewer();
            mainReportViewer.ProcessingMode = ProcessingMode.Local;
            mainReportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\SampleReport.rdlc";

            var productList = new List<ProductCategory>();
            using (var context = new AdventureWorks2008Entities())
            {
                productList = context.ProductCategories.ToList();
            }

            mainReportViewer.LocalReport.DataSources.Add(new ReportDataSource() { Name = "ProductCategory", Value = productList });

            var bytes = mainReportViewer.LocalReport.Render("PDF");

            Response.ContentType = "application/pdf";
            Response.Headers.Add("content-disposition", "attachment");
            Response.BinaryWrite(bytes);
            Response.Flush();
            return new ContentResult();
        }
    }
}
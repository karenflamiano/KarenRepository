using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LocalReportDemo.Entities;

namespace LocalReportDemo.Reports
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mainReportViewer.ProcessingMode = ProcessingMode.Local;
                mainReportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\SampleReport.rdlc";

                var productList = new List<ProductCategory>();
                using (var context = new AdventureWorks2008Entities())
                {
                    productList = context.ProductCategories.ToList();
                }

                mainReportViewer.LocalReport.DataSources.Add(new ReportDataSource() { Name = "ProductCategory", Value = productList });
                mainReportViewer.LocalReport.Refresh();
            }
        }
    }
}
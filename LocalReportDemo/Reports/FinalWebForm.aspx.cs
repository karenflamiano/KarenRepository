using LocalReportDemo.Entities;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LocalReportDemo.Reports
{
    public partial class FinalWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\FinalReport.rdlc";

                var productList = new List<ProductCategory>();
                using (var context = new AdventureWorks2008Entities())
                {
                    productList = context.ProductCategories.Include("ProductSubcategories").ToList();
                }

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource() { Name = "Product", Value = productList });
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource() { Name = "ProductSubCategory", Value = productList.First().ProductSubcategories});
                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}
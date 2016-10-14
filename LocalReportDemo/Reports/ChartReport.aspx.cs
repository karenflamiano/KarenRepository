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
    public partial class ChartReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\Report2.rdlc";

                var productList = new List<ProductCategory>();
                using (var context = new AdventureWorks2008Entities())
                {
                    productList = context.ProductCategories.ToList();
                }

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource() { Name = "DataSet1", Value = productList });
                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}
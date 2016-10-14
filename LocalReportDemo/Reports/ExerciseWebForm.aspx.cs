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
    public partial class ExerciseWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ExerciseReportViewer1.ProcessingMode = ProcessingMode.Local;
                ExerciseReportViewer1.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\ExerciseReport.rdlc";

                var personList = new List<Person>();
                using (var context = new AdventureWorks2008Entities())
                {
                    personList = context.People.Include("PersonPhones").ToList();
                }
                ExerciseReportViewer1.LocalReport.DataSources.Add(new ReportDataSource() { Name = "Person", Value = personList.Where(x=> x.BusinessEntityID == 46) });
                ExerciseReportViewer1.LocalReport.DataSources.Add(new ReportDataSource() { Name = "Phone", Value = personList.Where(x => x.BusinessEntityID == 46).First().PersonPhones });
                ExerciseReportViewer1.LocalReport.Refresh();
            }
        }
    }
}
using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Report.Dashboard.Styles;

namespace Web_Demo
{
    public partial class _Default : Page
    {
        private string appDirectory = HttpContext.Current.Server.MapPath(string.Empty);
        static _Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("stimulsoft.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void StiWebViewer1_GetReport(object sender, StiReportDataEventArgs e)
        {
            var report = StiReport.CreateNewDashboard();
            var reportName = "DashboardChristmas";

            if (!string.IsNullOrEmpty(Page.Request.QueryString.Get("reportname")))
            {
                reportName = Page.Request.QueryString.Get("reportname");
            }

            report.Load(string.Format("{0}\\Dashboards\\{1}.mrt", appDirectory, reportName));

            e.Report = report;

        }

        protected void StiWebViewer1_DesignReport(object sender, EventArgs e)
        {
            var keyValue = Page.Request.QueryString.Get("reportname") ?? "DashboardChristmas";
            Response.Redirect("Designer.aspx?reportname=" + keyValue, true);
        }
    }
}
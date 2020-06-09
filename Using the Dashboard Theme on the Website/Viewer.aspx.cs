using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Using_the_Dashboard_Theme_on_the_Website
{
    public partial class _Viewer : Page
    {
        static _Viewer()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void StiWebViewer1_GetReport(object sender, Stimulsoft.Report.Web.StiReportDataEventArgs e)
        {
            var name = Page.Request.QueryString["name"] ?? "DashboardChristmas";
            var dashboardPath = Server.MapPath($"Dashboards/{name}.mrt");
            var report = StiReport.CreateNewDashboard();
            report.Load(dashboardPath);

            e.Report = report;
        }
    }
}
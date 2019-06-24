using Stimulsoft.Report;
using System;

namespace Web_Demo
{
    public partial class Designer : System.Web.UI.Page
    {
        static Designer()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebDesigner1_GetReport(object sender, Stimulsoft.Report.Web.StiReportDataEventArgs e)
        {
            var fileName = Page.Request.QueryString.Get("id") ?? "DashboardChristmas";

            var report = new StiReport();
            report.Load(Server.MapPath($"~/Dashboards/{fileName}.mrt"));

            e.Report = report;
        }
    }
}

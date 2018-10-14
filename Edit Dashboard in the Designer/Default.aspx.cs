using Stimulsoft.Report;
using System;
using System.Web.UI;

namespace Edit_Dashboard_in_the_Designer
{
    public partial class _Default : Page
    {
        static _Default()
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
            string dashboardPath = Server.MapPath("Dashboards/DashboardChristmas.mrt");
            var report = new StiReport();
            report.Load(dashboardPath);

            e.Report = report;
        }
    }
}
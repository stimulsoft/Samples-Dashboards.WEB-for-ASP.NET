using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Edit_Dashboard_in_the_Designer
{
    public partial class Default : Page
    {
        static Default()
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
            var report = StiReport.CreateNewDashboard();
            report.Load(dashboardPath);

            e.Report = report;
        }
    }
}
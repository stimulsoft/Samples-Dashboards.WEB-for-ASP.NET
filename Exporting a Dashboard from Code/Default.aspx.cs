using Stimulsoft.Report;
using Stimulsoft.Report.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exporting_a_Dashboard_from_Code
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

        private StiReport GetTemplate()
        {
            var report = StiReport.CreateNewDashboard();
            report.Load(Server.MapPath("Dashboards/DashboardChristmas.mrt"));

            return report;
        }

        protected void ButtonExportPdf_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();
            StiReportResponse.ResponseAsPdf(report);
        }

        protected void ButtonExportExcel_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();
            StiReportResponse.ResponseAsExcel2007(report);
        }

        protected void ButtonExportImage_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();
            StiReportResponse.ResponseAsPng(report);
        }
    }
}
using System;
using System.Web.UI;
using Stimulsoft.Report;

namespace Web_Demo
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
            var fileName = Page.Request.QueryString.Get("id") ?? "DashboardChristmas";

            var report = new StiReport();
            report.Load(Server.MapPath($"~/Dashboards/{fileName}.mrt"));
            StiWebViewer1.Report = report;
        }
    }
}
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Report;
using Stimulsoft.Report.Dashboard.Styles;

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

            var report = StiReport.CreateNewDashboard();
            report.Load(Server.MapPath($"~/Dashboards/{fileName}.mrt"));

            // Set styles for website from dashboard
            var dashboard = report.Pages[0] as StiDashboard;
            if (dashboard != null)
            {
                StiWebViewer1.BackgroundColor = StiDashboardStyleHelper.GetDashboardBackColor(dashboard, true);

                var mainPanel = Master.FindControl("MainPanel") as Panel;
                mainPanel.ForeColor = StiDashboardStyleHelper.GetForeColor(dashboard);
                mainPanel.BackColor = StiDashboardStyleHelper.GetDashboardBackColor(dashboard, true);
                
                var siteLink = Master.FindControl("SiteLink") as HyperLink;
                siteLink.ForeColor = StiDashboardStyleHelper.GetForeColor(dashboard);

                var dashboardsPanel = Master.FindControl("DashboardsPanel") as Panel;
                foreach (var control in dashboardsPanel.Controls)
                {
                    var link = control as HyperLink;
                    if (link != null)
                        link.ForeColor = StiDashboardStyleHelper.GetForeColor(dashboard);
                }
            }

            StiWebViewer1.Report = report;
        }

        protected void StiWebViewer1_DesignReport(object sender, Stimulsoft.Report.Web.StiReportDataEventArgs e)
        {
            var fileName = Page.Request.QueryString.Get("id") ?? "DashboardChristmas";
            Response.Redirect("/Designer.aspx?id=" + fileName);
        }
    }
}
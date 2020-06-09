using Stimulsoft.Dashboard.Components;
using Stimulsoft.Report;
using Stimulsoft.Report.Dashboard.Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Using_the_Dashboard_Theme_on_the_Website
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = Page.Request.QueryString["name"];
            if (!string.IsNullOrEmpty(name))
            {
                var dashboardPath = Server.MapPath($"Dashboards/{name}.mrt");
                var report = StiReport.CreateNewDashboard();
                report.Load(dashboardPath);

                // Get theme colors from the dashboard page
                var dashboard = report.Pages[0] as StiDashboard;
                var bashboardBackHtmlColor = ColorTranslator.ToHtml(dashboard != null ? StiDashboardStyleHelper.GetDashboardBackColor(dashboard, true) : Color.White);
                var backHtmlColor = ColorTranslator.ToHtml(dashboard != null ? StiDashboardStyleHelper.GetBackColor(dashboard) : Color.White);
                var foreHtmlColor = ColorTranslator.ToHtml(dashboard != null ? StiDashboardStyleHelper.GetForeColor(dashboard) : Color.Black);

                // Set styles
                Body.Style.Add("background", bashboardBackHtmlColor);
                NavigationBar.Style.Add("background", backHtmlColor);
                LinkTitle.Style.Add("color", foreHtmlColor);
                LinkHome.Style.Add("color", foreHtmlColor);
                LinkAbout.Style.Add("color", foreHtmlColor);
                LinkContacts.Style.Add("color", foreHtmlColor);
                TextCopyright.Style.Add("color", foreHtmlColor);
            }
        }
    }
}
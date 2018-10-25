using System;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Demo
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var dashboardFiles = Directory.GetFiles(Server.MapPath("/Dashboards"), "*.mrt");
                foreach (var filePath in dashboardFiles)
                {
                    var fileName = Path.GetFileNameWithoutExtension(filePath);
                    var link = new HyperLink()
                    {
                        Text = fileName.Substring(9),
                        NavigateUrl = $"Default/?id={fileName}",
                        CssClass = (Page.Request.QueryString.Get("id") ?? "DashboardChristmas") == fileName ? "current" : ""
                    };
                    
                    PanelDashboards.Controls.Add(link);
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
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
                    var fileName = Path.GetFileName(filePath);
                    var item = new ListItem(fileName.Substring(9, fileName.Length - 9 - 4), filePath);
                    ListBoxDashboards.Items.Add(item);
                }

                ListBoxDashboards.SelectedIndex = 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}
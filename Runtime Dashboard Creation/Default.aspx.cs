using Stimulsoft.Report.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Runtime_Dashboard_Creation
{
    public partial class Default : Page
    {
        private static string appPath;

        static Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            appPath = Server.MapPath(string.Empty);
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            StiWebViewer1.Visible = true;
            StiWebDesigner1.Visible = false;

            StiWebViewer1.Report = Dashboard.CreateTemplate(appPath);
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            StiWebViewer1.Visible = false;
            StiWebDesigner1.Visible = true;

            StiWebDesigner1.Report = Dashboard.CreateTemplate(appPath);
        }

        protected void ButtonExport_Click(object sender, EventArgs e)
        {
            StiWebViewer1.Visible = false;
            StiWebDesigner1.Visible = false;

            var dashboard = Dashboard.CreateTemplate(appPath);
            StiReportResponse.ResponseAsExcel2007(dashboard);
        }
    }
}
using Stimulsoft.Base.Drawing;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Dashboard.Components.Text;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Runtime_Dashboard_Creation
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

        private StiReport CreateTemplate()
        {
            var report = StiReport.CreateNewDashboard();
            var dashboard = report.Pages[0] as StiDashboard;

            var textElement = new StiTextElement();
            textElement.Left = 100;
            textElement.Top = 100;
            textElement.Width = 300;
            textElement.Height = 100;
            textElement.Text = "Sample Text";
            textElement.Border.Side = StiBorderSides.All;
            textElement.BackColor = Color.LightGray;

            dashboard.Components.Add(textElement);

            return report;
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            StiWebViewer1.Visible = true;
            StiWebDesigner1.Visible = false;

            StiWebViewer1.Report = CreateTemplate();
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            StiWebViewer1.Visible = false;
            StiWebDesigner1.Visible = true;

            StiWebDesigner1.Report = CreateTemplate();
        }
    }
}
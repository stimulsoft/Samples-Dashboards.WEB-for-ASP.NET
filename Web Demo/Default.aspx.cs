using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            var listBox = (ListBox)Master.FindControl("ListBoxDashboards");
            var filePath = listBox.SelectedValue;

            var report = new StiReport();
            report.Load(filePath);
            StiWebViewer1.Report = report;
        }
    }
}
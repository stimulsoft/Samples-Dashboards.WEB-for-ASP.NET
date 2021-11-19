using Stimulsoft.Data.Extensions;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adding_a_Custom_Function_to_the_Designer
{
    public partial class Default : Page
    {
        public static decimal MySum(object value)
        {
            if (!ListExt.IsList(value))
                return Stimulsoft.Base.Helpers.StiValueHelper.TryToDecimal(value);

            return Stimulsoft.Data.Functions.Funcs.SkipNulls(ListExt.ToList(value))
                .TryCastToDecimal()
                .Sum();
        }

        static Default()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            // How to add my function
            StiFunctions.AddFunction("MyCategory", "MySum",
                "description", typeof(Default),
                typeof(decimal), "Calculates a sum of the specified set of values.",
                new[] { typeof(object) },
                new[] { "values" },
                new[] { "A set of values" }).UseFullPath = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StiWebDesigner1_GetReport(object sender, Stimulsoft.Report.Web.StiReportDataEventArgs e)
        {
            var dashboardPath = Server.MapPath("Dashboards/DashboardChristmas.mrt");
            var report = StiReport.CreateNewDashboard();
            report.Load(dashboardPath);

            e.Report = report;
        }
    }
}
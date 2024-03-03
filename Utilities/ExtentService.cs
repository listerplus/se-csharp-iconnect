using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace se_csharp_iconnect.Utilities
{
    // Create instance of ExtentReports if not present else return instance
    public class ExtentService
    {
        public static ExtentReports extent;

        public static ExtentReports GetExtent()
        {
            if (extent == null)
            {
                extent = new ExtentReports();
                string reportDir = Path.Combine(Util.GetProjRootDir(), "Reports");
                if (!Directory.Exists(reportDir)) Directory.CreateDirectory(reportDir);

                string path = Path.Combine(reportDir, "Report.html");
                var reporter = new ExtentSparkReporter(path);
                reporter.Config.ReportName = "Test Automation Report";
                // OR create xml for report config
                // string extentConfigPath = filePath + "\\extent-config.xml"
                // reporter.LoadConfig(extentConfigPath)
                extent.AttachReporter(reporter);
            }
            // Succeeding test has extent != null and will use the same extent object and appends the result
            return extent;
        }

    }
}

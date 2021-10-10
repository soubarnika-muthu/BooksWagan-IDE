using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace BookswagonProject.Action
{
    public class ReportClass
    {
        //Instance of extents reports
        public static ExtentHtmlReporter htmlReporter;
        // create ExtentReports and attach reporter(s)
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports Start_Report()
        {
            if (extent == null)
            {
                //current solution report path
                string reportPath = @"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\Reports\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                //attaching html reporter
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Soubarnika");
                extent.AddSystemInfo("ProviderName", "Soubarnika");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "BooksWagan Automation");
                //Adding config.xml file
                string conifgPath = @"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\Reports\Report-Config.xml";
                htmlReporter.LoadConfig(conifgPath);


            }
            return extent;
        }

    }
}

using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace se_csharp_iconnect.Utilities
{
    public class DriverSetup
    {
        // https://learn.microsoft.com/en-us/dotnet/api/system.configuration.configurationmanager?view=dotnet-plat-ext-8.0
        // Reads the project's App.config file
        private static string? browserName = ConfigurationManager.AppSettings["Browser"];
        public static string? uri = ConfigurationManager.AppSettings["Server"];
        public static IWebDriver BrowserSetup(IWebDriver driver)
        {

            if (browserName.ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browserName.ToLower() == "firefox")
            {
                driver = new FirefoxDriver();
            }
            else if (browserName.ToLower() == "edge")
            {
                driver = new EdgeDriver();
            }
            else
            {
                Console.WriteLine("Default Browser Chrome initiated, please check browser details in app.config file");
                driver = new ChromeDriver();
            }

            return driver;

        }
    }
}

using System;
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
        public static string? browserName = ConfigurationManager.AppSettings["Browser"];
        private static string? _uri;
        public static string? Uri
        {
            get
            {
                _uri = ConfigurationManager.AppSettings["Server"];
                // If _uri is null or empty, set a hardcode uri 
                if (string.IsNullOrWhiteSpace(_uri))
                {
                    _uri = "horse.industryconnect.io";
                }
                return _uri;
            }
            set => _uri = value;
        }

        public static IWebDriver BrowserSetup(IWebDriver driver)
        {
            string? uri = ConfigurationManager.AppSettings["Server"];
            if (string.IsNullOrWhiteSpace(browserName))
            {
                Console.WriteLine("Browser not specified in App.config. Defaulting to Chrome.");
                driver = new ChromeDriver();
            }
            else
            {
                switch (browserName.ToLower())
                {
                    case "chrome":
                        driver = new ChromeDriver();
                        break;
                    case "firefox":
                        driver = new FirefoxDriver();
                        break;
                    default:
                        Console.WriteLine($"Unrecognized browser: {browserName}. Defaulting to Chrome.");
                        driver = new ChromeDriver();
                        break;
                }
            }
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}

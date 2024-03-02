using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using se_csharp_iconnect.Utilities;

namespace se_csharp_iconnect.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void StartBrowser()
        {
            driver = DriverSetup.BrowserSetup(driver);
            string? url = DriverSetup.uri;
            driver.Navigate().GoToUrl(url);
        }

        public IWebDriver GetDriver()
        {
            return driver;

        }

        [OneTimeTearDown]
        public void Close() 
        {
            driver.Quit();
        }
    }
}

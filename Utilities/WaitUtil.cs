using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace se_csharp_iconnect.Utilities
{
    public class WaitUtil
    {
        private const int DefaultTimeout = 10;
        public static void WaitVisible(IWebDriver driver, By by, int timeoutInSeconds = DefaultTimeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static void WaitClickable(IWebDriver driver, By by, int timeoutInSeconds = DefaultTimeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static void WaitSelected(IWebDriver driver, By by, int timeoutInSeconds = DefaultTimeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementToBeSelected(by));
        }

        // Add more methods based on your needs

        // Example usage:
        // WaitUtil.WaitVisible(driver, By.Id("exampleId"));
    }
}

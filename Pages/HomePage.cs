using OpenQA.Selenium;

namespace se_csharp_iconnect.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        IWebElement btnDashboard => _driver.FindElement(By.XPath("//li[@class='menuitem']/a[contains(text(),'Dashboard')]"));
        IWebElement btnJobs => _driver.FindElement(By.Id("//a[@href='/Job']"));
        IWebElement btnJobsCalendar => _driver.FindElement(By.Id("//a[@href='/Scheduler']"));
        IWebElement btnStaffCalendar => _driver.FindElement(By.Id("//a[@href='/StaffCalendar']"));
        IWebElement dropdownAdministration => _driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
        IWebElement customersOption => _driver.FindElement(By.XPath("///a[@href='/Client']"));
        IWebElement employeesOption => _driver.FindElement(By.XPath("//a[@href='/User']"));
        IWebElement TMOption => _driver.FindElement(By.XPath("//a[@href='/TimeMaterial']"));
        public IWebElement helloRegion => _driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]//a[@class=\"dropdown-toggle\"][@role=\"button\"]"));



        public void NavigateToTMPage()
        {
            dropdownAdministration.Click();
            TMOption.Click();
        }

        public void NavigateToEmployeePage()
        {
            dropdownAdministration.Click();
            employeesOption.Click();
        }

        public string GetLoggedInUser()
        {
            return helloRegion.Text;
            //should return "Hello user!"
        }

    }
}

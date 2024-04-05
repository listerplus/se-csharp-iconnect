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

        // By locators
        By btnDashboardBy = By.XPath("//li[@class='menuitem']/a[contains(text(),'Dashboard')]");
        By btnJobsBy = By.Id("//a[@href='/Job']");
        By btnJobsCalendarBy = By.Id("//a[@href='/Scheduler']");
        By btnStaffCalendarBy = By.Id("//a[@href='/StaffCalendar']");
        By dropdownAdministrationBy = By.XPath("//*[contains(text(),'Administration')]");
        By customersOptionBy = By.XPath("///a[@href='/Client']");
        By employeesOptionBy = By.XPath("//a[@href='/User']");
        By TMOptionBy = By.XPath("//a[@href='/TimeMaterial']");
        public By helloRegionBy = By.XPath("//*[@id=\"logoutForm\"]//a[@class=\"dropdown-toggle\"][@role=\"button\"]");



        public void NavigateToTMPage()
        {
            _driver.FindElement(dropdownAdministrationBy).Click();
            _driver.FindElement(TMOptionBy).Click();
        }

        public void NavigateToEmployeePage()
        {
            _driver.FindElement(dropdownAdministrationBy).Click();
            _driver.FindElement(employeesOptionBy).Click();
        }

        public string GetLoggedInMessage()
        {
            return _driver.FindElement(helloRegionBy).Text;
            //should return "Hello user!"
        }

    }
}

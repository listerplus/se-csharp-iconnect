using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using se_csharp_iconnect.Pages;

namespace se_csharp_iconnect
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("todo_url");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            LoginPage loginPage = new LoginPage(_driver);
            Assert.Pass();
        }
    }
}
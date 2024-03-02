using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using se_csharp_iconnect.Utilities;

namespace se_csharp_iconnect.Pages
{
    public class LoginPage
    {
        public readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /* Locators
        IWebElement TxtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement TxtPassword => driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => driver.FindElement(By.XPath("//input[@value='Log in']"));
        public IWebElement ErrorField => driver.FindElement(By.XPath("//div[@class='validation-summary-errors']/ul/li"));
        */

        // By Locators
        public By TxtUserNameBy => By.Id("UserName");
        public By TxtPasswordBy => By.Id("Password");
        public By BtnLoginBy => By.XPath("//input[@value='Log in']");
        public By ErrorFieldBy => By.XPath("//div[@class='validation-summary-errors']/ul/li");

        // Text
        public readonly string userValid = "hari";
        public readonly string passwordValid = "123123";
        public readonly string userInValid = "test";
        public readonly string passwordInValid = "test";
        public readonly string errorInValid = "Invalid username or password.";

        // Methods
        public void ClickLogin() 
        {
            WaitUtil.WaitVisible(driver, BtnLoginBy);
            driver.FindElement(BtnLoginBy).Click();
        }

        public void Login(string username, string password) 
        {
            driver.FindElement(TxtUserNameBy).SendKeys(username);
            driver.FindElement(TxtPasswordBy).SendKeys(password);
            driver.FindElement(BtnLoginBy).Click();
        }




    }
}

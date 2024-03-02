using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace se_csharp_iconnect.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        IWebElement TxtUserName => _driver.FindElement(By.Id("UserName"));
        IWebElement TxtPassword => _driver.FindElement(By.Id("Password"));
        IWebElement BtnLogin => _driver.FindElement(By.Id("//input[@value='Log in']"));

        public readonly string userValid = "hari";
        public readonly string passwordValid = "123123";
        public readonly string userInValid = "hari";
        public readonly string passwordInValid = "123123";

        public void ClickLogin() 
        {
            BtnLogin.Click();
        }

        public void Login(string username, string password) 
        {
            TxtUserName.SendKeys(userValid);
            TxtPassword.SendKeys(passwordValid);
            BtnLogin.Submit();
        }




    }
}

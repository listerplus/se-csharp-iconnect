using se_csharp_iconnect.Pages;
using se_csharp_iconnect.Utilities;

namespace se_csharp_iconnect.Tests
{
    [Category("Smoke")]
    [Category("Regression")]
    [Author("Lister Sandalo")]
    public class TestLogin : BaseTest
    {
        [Test]
        public void Test01LoginInvalidCredentials()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginCredentials(loginPage.userInValid, loginPage.passwordInValid);
            WaitUtil.WaitVisible(driver, loginPage.ErrorFieldBy);
            ReportLog.Info($"Used cred : user: {loginPage.userInValid}, pwd: {loginPage.passwordInValid}");
            Assert.That(driver.FindElement(loginPage.ErrorFieldBy).Text, Is.EqualTo(loginPage.errorInValid));
        }

        [Test]
        public void Test02LoginValidCredentials()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginCredentials(loginPage.userValid, loginPage.passwordValid);
            HomePage homePage = new HomePage(driver);
            string helloMessage = $"Hello {loginPage.userValid}!";
            ReportLog.Info($"Used cred : user: {loginPage.userValid}, pwd: {loginPage.passwordValid}");
            Assert.That(homePage.GetLoggedInMessage(), Is.EqualTo(helloMessage));

        }
    }
}

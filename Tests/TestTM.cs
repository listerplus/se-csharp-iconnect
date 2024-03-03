using se_csharp_iconnect.Pages;
using se_csharp_iconnect.Utilities;

namespace se_csharp_iconnect.Tests
{
    [Parallelizable]
    public class TestTM : BaseTest
    {
        [SetUp]
        public void Login() 
        { 
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login();
            HomePage home = new HomePage(driver);
            home.NavigateToTMPage();
        }

        [Test]
        public void Test01DeleteItem()
        {
            TimeMaterialPage TMPage = new TimeMaterialPage(driver);
            int count = TMPage.GetItemsCount();
            if (count == 0) { Assert.Ignore("No item in Table"); }

            TMPage.DeleteFirstItem();
            int newcount = TMPage.GetItemsCount();
            Assert.That(newcount, Is.EqualTo(count - 1));
            ReportLog.Pass($"New count: {newcount}, which is previous count of {count} - 1");
        }
    }
}

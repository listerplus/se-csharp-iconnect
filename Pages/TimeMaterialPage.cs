using System.Text.RegularExpressions;
using OpenQA.Selenium;
using se_csharp_iconnect.Utilities;

namespace se_csharp_iconnect.Pages
{
    public class TimeMaterialPage
    {
        private readonly IWebDriver _driver;

        public TimeMaterialPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        // By Locators
        public static By BtnCreateNewBy => By.XPath("//a[@href='/TimeMaterial/Create']");
        public static By BtnGoToFirstPageBy => By.XPath("//*[@id='tmsGrid']//a[@title='Go to the first page']");
        public static By BtnGoToLastPageBy => By.XPath("//*[@id='tmsGrid']//a[@title='Go to the last page']");
        public static By TableInfoFieldBy => By.XPath("//*[@class='k-pager-info k-label']");
        public static By TableNumSelectedBy => By.XPath("//*[@class='k-state-selected']");
        public static By TableBtnDelFirstBy => By.XPath("//*[@id='tmsGrid']//tbody/tr[1]//a[@class='k-button k-button-icontext k-grid-Delete']");
        

        // Methods
        public void ClickCreateNew()
        {
            WaitUtil.WaitVisible(_driver, BtnCreateNewBy);
            _driver.FindElement(BtnCreateNewBy).Click();
        }

        public string GetTableNumSelected()
        {
            return _driver.FindElement(TableNumSelectedBy).Text;
        }

        public int GetItemsCount()
        {
            Thread.Sleep(2000);
            WaitUtil.WaitVisible(_driver, TableInfoFieldBy);
            string tableInfo = _driver.FindElement(TableInfoFieldBy).Text;
            //Console.WriteLine("Tableinfo: " + tableInfo);
            Regex pattern = new Regex(@"(?<itemx>\d+) - (?<itemy>\d+) of (?<itemTotal>\d+)");
            Match match = pattern.Match(tableInfo);
            int itemTotal = int.Parse(match.Groups["itemTotal"].Value);
            //Console.WriteLine("count: " + itemTotal);
            return itemTotal;
        }

        public void DeleteFirstItem()
        {
            try
            {
                _driver.FindElement(TableBtnDelFirstBy).Click();
                _driver.SwitchTo().Alert().Accept();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception: " + ex);
            }
        }
    }
}

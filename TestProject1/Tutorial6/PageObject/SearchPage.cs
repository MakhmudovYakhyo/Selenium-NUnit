using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Net.NetworkInformation;

namespace TestProject1.PageObject
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='search']")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-icon-legacy']")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResultPage()
        {
            SearchTextBox.SendKeys("TheTechie AutomationLabs");
            SearchButton.Click();

            return new ResultPage(driver);
        }
    }
}

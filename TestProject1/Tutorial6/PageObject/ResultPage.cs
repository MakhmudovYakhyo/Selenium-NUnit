using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PageObject
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "TheTechie AutomationLabs")]
        public IWebElement ChannelLinkText { get; set; }

        public ChannelPage NavigateToChannel()
        {
            Thread.Sleep(3000);
            ChannelLinkText.Click();
            return new ChannelPage(driver);
        }
    }
}

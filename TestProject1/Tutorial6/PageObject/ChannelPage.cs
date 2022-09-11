using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.PageObject
{
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='inner-header-container']//div[@id='meta']//ytd-channel-name[@id='channel-name']//div[@id='container']//div[@id='text-container']//yt-formatted-string[@id='text']")]
        public IWebElement ChannelName { get; set; }

        public String GetChannelName()
        {
            Thread.Sleep(3000);
            return ChannelName.Text;
        }
    }
}

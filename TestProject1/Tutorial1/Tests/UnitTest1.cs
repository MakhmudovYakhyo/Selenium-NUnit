using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TestProject1.BaseClass;

namespace TestProject1.Tests
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {

        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {

            /*IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");*/
            IWebElement monthDropDownList = driver.FindElement(By.XPath("//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1); //Select by Index
            Thread.Sleep(2000);
            element.SelectByText("Mar"); //Select by Text
            Thread.Sleep(2000);
            element.SelectByValue("6"); //Select by Value
            Thread.Sleep(2000);
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

        }
    }

}
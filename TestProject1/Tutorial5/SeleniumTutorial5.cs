using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TestProject1.Tutorial5
{
    [TestFixture]
    public class SeleniumTutorial5
    {
        ExtentReports extent = null;
        [OneTimeSetUp] 
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\PDP\SDET\VisualStudio\TestProject1\TestProject1\TestProject1\Tutorial5\ExtentReports\SeleniumTutorial5.html");
            extent.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test]
        public void TestMethod1()
        {
            ExtentTest test = null;
            IWebDriver driver = null;
            try
            {
                test = extent.CreateTest("TestMethod1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info,"Chrome Browser launched");
                driver.Url = "https://www.facebook.com/";
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                emailTextField.SendKeys("Selenium C#");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "TestMethod1 passed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                test.Log(Status.Fail,e.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }

            }


        }

        [Test]
        public void TestMethod2()
        {
            ExtentTest test = null;
            IWebDriver driver = null;
            try
            {
                test = extent.CreateTest("TestMethod2").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser launched");
                driver.Url = "https://www.facebook.com/";
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "TestMethod1 passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }

            }


        }
    }
}

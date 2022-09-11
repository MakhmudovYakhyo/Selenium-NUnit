using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections;

namespace TestProject1.Tutorial4
{
    [TestFixture]
    public class SeleniumTutorial4
    {
        [Test]
        [Author("Bakkapa","bakkappac@gmail.com")]
        [Description("Facebook login Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void TestMethod1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("D:\\PDP\\SDET\\VisualStudio\\TestProject1\\TestProject1\\TestProject1\\Tutorial4\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
               
            }

            
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();

            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;
        }

        /*[Test]
        [Author("Bakkapa", "bakkappac@gmail.com")]
        [Description("Facebook login Verify")]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Quit();
        }*/
    }
}

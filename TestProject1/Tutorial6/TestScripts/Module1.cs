using TestProject1.BaseClass;
using TestProject1.PageObject;

namespace TestProject1.Tutorial6.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var searchPage = new SearchPage(driver);
            var resultPage = searchPage.NavigateToResultPage();
            var channelPage = resultPage.NavigateToChannel();
            string actualChannelName = channelPage.GetChannelName();
            string expectedChannelName = "TheTechie AutomationLabs";
            Assert.IsTrue(actualChannelName.Equals(expectedChannelName));
            Thread.Sleep(5000);

        }
    }
}

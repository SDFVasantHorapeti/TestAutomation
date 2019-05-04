using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace BrowserStackTest
{
    [TestFixture]
    [Parallelizable]
    class AccountManagement
    {

        public static string GetSearchKey()
        {
            return System.Environment.GetEnvironmentVariable("SearchResultKey");
        }

        [Test]
        [Category("NonProduction")]
        [Category("Production")]
        [Parallelizable]
        [Obsolete]
        public void UserLogin1()
        {
            //This is for auto merge and auto delete branch
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalCapability("os_version", "10", true);
            options.AddAdditionalCapability("native_events", "false", true);
            options.AddAdditionalCapability("os", "Windows", true);
            options.AddAdditionalCapability("browser_version", "62", true);

            //options.AddAdditionalCapability("browserstack.user", "vasanthorapeti2");
            //options.AddAdditionalCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

            /*
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti1");
            caps.SetCapability("browserstack.key", "vk61BzMs3DrmxHCuwzAp");
            */

            driver = new RemoteWebDriver(new Uri("http://vasanthorapeti2:qSHea3BnLWduVXdm57sR@hub-cloud.browserstack.com/wd/hub/"), options.ToCapabilities());

            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine(driver.Title);

            //string expectedResults = TestContext.Parameters.Get("SearchResultKey");
            string expectedResults = System.Environment.GetEnvironmentVariable("SearchResultKey");

            Console.WriteLine(expectedResults);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("BrowserStack");
            query.Submit();
            Console.WriteLine(driver.Title);
            Assert.AreEqual(expectedResults, driver.Title);
            driver.Quit();
        }

    }
}

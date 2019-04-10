using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BrowserStackTest
{
    [TestFixture]
    class AccountManagement
    {
        [Test]
        [Obsolete]
        public void UserLogin()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti1");
            caps.SetCapability("browserstack.key", "vk61BzMs3DrmxHCuwzAp");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine(driver.Title);

            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("BrowserStack");
            query.Submit();
            Console.WriteLine(driver.Title);
            Assert.AreEqual("BrowserStack - Google zoeken", driver.Title);
            driver.Quit();
        }

        [Test]
        [Obsolete]
        public void ResetPassword()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti1");
            caps.SetCapability("browserstack.key", "vk61BzMs3DrmxHCuwzAp");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine(driver.Title);

            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Brother International");
            query.Submit();
            Console.WriteLine(driver.Title);
            Assert.AreEqual("Brother International - Google zoeken", driver.Title);
            driver.Quit();
        }

    }
}

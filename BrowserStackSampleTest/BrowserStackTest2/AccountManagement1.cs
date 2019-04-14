using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using BrowserStackTest;

namespace BrowserStackTest2
{
    [TestFixture]
    [Parallelizable]
    class AccountManagement1
    {
        [Test]
        [Parallelizable]
        [Obsolete]
        public void UserLogin1()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine(driver.Title);

            //string expectedResults = TestContext.Parameters.Get("SearchResultKey");
            
            string expectedResults = Common.GetSearchKey();

            Console.WriteLine(expectedResults);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("BrowserStack");
            query.Submit();
            Console.WriteLine(driver.Title);
            Assert.AreEqual(expectedResults, driver.Title);
            driver.Quit();
        }

        [Test]
        [Parallelizable]
        [Obsolete]
        public void UserLogin2()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
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

        [Test]
        [Parallelizable]
        [Obsolete]
        public void UserLogin3()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
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

        [Test]
        [Parallelizable]
        [Obsolete]
        public void UserLogin4()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
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
        [Test]
        [Parallelizable]
        [Obsolete]
        public void UserLogin5()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

            driver = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps
            );
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
        [Test]
        [Parallelizable]
        [Obsolete]
        public void ResetPassword1()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

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
        [Test]
        [Parallelizable]
        [Obsolete]
        public void ResetPassword2()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

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
        [Test]
        [Parallelizable]
        [Obsolete]
        public void ResetPassword3()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

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
        [Test]
        [Parallelizable]
        [Obsolete]
        public void ResetPassword4()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

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
        [Test]
        [Parallelizable]
        [Obsolete]
        public void ResetPassword5()
        {
            IWebDriver driver;
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "62.0");
            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("resolution", "1024x768");
            caps.SetCapability("browserstack.user", "vasanthorapeti2");
            caps.SetCapability("browserstack.key", "qSHea3BnLWduVXdm57sR");

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

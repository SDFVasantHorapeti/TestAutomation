using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace BrowserStackTest
{
    class VPNTesting
    {

        [Test]
      public void TestVPNSite()
        {
            ChromeOptions options = new ChromeOptions();

            string username = Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME");
            string accessKey = Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY");
            string browserStackLocal = Environment.GetEnvironmentVariable("BROWSERSTACK_LOCAL");
            string browserStackLocalIdentifier = Environment.GetEnvironmentVariable("BROWSERSTACK_LOCAL_IDENTIFIER");

            options.AddAdditionalCapability("os", "Windows", true);
            options.AddAdditionalCapability("os_version", "10", true);
            options.AddAdditionalCapability("browser_version", "62", true);
            options.AddAdditionalCapability("browserstack.local", browserStackLocal, true);
            options.AddAdditionalCapability("browserstack.localIdentifier", browserStackLocalIdentifier, true);

            IWebDriver driver = new RemoteWebDriver(new Uri("http://vasanthorapeti2:qSHea3BnLWduVXdm57sR@hub-cloud.browserstack.com/wd/hub/"), options.ToCapabilities());

            driver.Navigate().GoToUrl("http://biepc310:84/app#/");
            Console.WriteLine(driver.Title);
            System.Threading.Thread.Sleep(3000);
            driver.Quit();
        }
      
    }
}

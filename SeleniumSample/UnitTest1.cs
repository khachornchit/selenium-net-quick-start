using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace SeleniumSample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FirefoxDriverService driver = new FirefoxDriverService(("C:\\SeleniumDriver\\chromedriver.exe");
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Quit();
        }
    }
}

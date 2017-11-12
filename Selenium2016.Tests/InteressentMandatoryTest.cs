using Selenium2016.Models;
using Selenium2016.Models.NewDesigned;
using Selenium2016.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUtilities;
using System;

namespace Selenium2016.Tests
{
    [TestClass]
    public class InteressentMandatoryTest
    {
        [TestInitialize]
        public void DefineDefaultBrowser()
        {
            PropertiesCollection.SetDefaultBrowserChrome();
        }

        [TestMethod]
        public void InteressentProcessTestTop()
        {
            Console.WriteLine(string.Format("{0} Interessent Process Test Top Elements", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(WorkAndStudy.Url);
            WorkAndStudy page = new WorkAndStudy();
            if (page.InteressentMandatoryFill()) { };
            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void InteressentProcessTestBottom()
        {
            Console.WriteLine(string.Format("{0} Interessent Process Test Bottom Elements", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(WorkAndStudy.Url);
            WorkAndStudy page = new WorkAndStudy();
            if (page.InteressentMandatoryFillBottom()) { };
            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }
    }
}
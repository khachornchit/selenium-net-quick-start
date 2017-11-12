using Selenium2016.Models;
using Selenium2016.Models.NewDesigned;
using Selenium2016.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUtilities;
using System;

namespace Selenium2016.Tests
{
    [TestClass]
    public class ApplicantMandatoryTest
    {
        [TestMethod]
        public void ApplicantMandatoryTestWebDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", WebDeveloper.Name));
            PropertiesCollection.OpenBrowser(WebDeveloper.Url);
            WebDeveloper page = new WebDeveloper();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestWebDesigner()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", WebDesigner.Name));
            PropertiesCollection.OpenBrowser(WebDesigner.Url);
            WebDesigner page = new WebDesigner();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestUiDesigner()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", UiDesigner.Name));
            PropertiesCollection.OpenBrowser(UiDesigner.Url);
            UiDesigner page = new UiDesigner();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestPhpDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", PhpDeveloper.Name));
            PropertiesCollection.OpenBrowser(PhpDeveloper.Url);
            PhpDeveloper page = new PhpDeveloper();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestJavaDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", JavaDeveloper.Name));
            PropertiesCollection.OpenBrowser(JavaDeveloper.Url);
            JavaDeveloper page = new JavaDeveloper();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestItManager()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", ItManager.Name));
            PropertiesCollection.OpenBrowser(ItManager.Url);
            ItManager page = new ItManager();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestArtDirector()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", ArtDirector.Name));
            PropertiesCollection.OpenBrowser(ArtDirector.Url);
            ArtDirector page = new ArtDirector();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryTestAndroidDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Test", AndroidDeveloper.Name));
            PropertiesCollection.OpenBrowser(AndroidDeveloper.Url);
            AndroidDeveloper page = new AndroidDeveloper();
            if (page.ApplicantMandatoryTest())
            {
            };

            foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }
    }
}

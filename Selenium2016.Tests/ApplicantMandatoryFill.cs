using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUtilities;
using System;

namespace Selenium2016.Tests
{
    [TestClass]
    public class ApplicantMandatoryFill
    {
        [TestInitialize]
        public void DefineDefaultBrowser()
        {
            PropertiesCollection.SetDefaultBrowserChrome();
        }

        [TestMethod]
        public void ApplicantMandatoryFillAdministrativeAssistant()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", AdministrativeAssistant.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(AdministrativeAssistant.JobAlias));
            AdministrativeAssistant page = new AdministrativeAssistant();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeEnglish()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeEnglish.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeEnglish.JobAlias));
            CustomerCareRepresentativeEnglish page = new CustomerCareRepresentativeEnglish();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeFrench()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeFrench.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeFrench.JobAlias));
            CustomerCareRepresentativeFrench page = new CustomerCareRepresentativeFrench();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeGerman()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeGerman.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeGerman.JobAlias));
            CustomerCareRepresentativeGerman page = new CustomerCareRepresentativeGerman();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeItalian()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeItalian.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeItalian.JobAlias));
            CustomerCareRepresentativeItalian page = new CustomerCareRepresentativeItalian();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeSpanish()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeSpanish.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeSpanish.JobAlias));
            CustomerCareRepresentativeSpanish page = new CustomerCareRepresentativeSpanish();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeSwiss()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeSwiss.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeSwiss.JobAlias));
            CustomerCareRepresentativeSwiss page = new CustomerCareRepresentativeSwiss();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillCustomerCareRepresentativeThai()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", CustomerCareRepresentativeThai.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(CustomerCareRepresentativeThai.JobAlias));
            CustomerCareRepresentativeThai page = new CustomerCareRepresentativeThai();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillOfficeAssistant()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", OfficeAssistant.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(OfficeAssistant.JobAlias));
            OfficeAssistant page = new OfficeAssistant();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesAgentEnglish()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesAgentEnglish.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesAgentEnglish.JobAlias));
            SalesAgentEnglish page = new SalesAgentEnglish();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesAgentFrench()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesAgentFrench.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesAgentFrench.JobAlias));
            SalesAgentFrench page = new SalesAgentFrench();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesAgentGerman()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesAgentGerman.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesAgentGerman.JobAlias));
            SalesAgentGerman page = new SalesAgentGerman();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesAgentItalian()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesAgentItalian.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesAgentItalian.JobAlias));
            SalesAgentItalian page = new SalesAgentItalian();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesAgentJapanese()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesAgentJapanese.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesAgentJapanese.JobAlias));
            SalesAgentJapanese page = new SalesAgentJapanese();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesAgentThai()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesAgentThai.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesAgentThai.JobAlias));
            SalesAgentThai page = new SalesAgentThai();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSalesManager()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SalesManager.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SalesManager.JobAlias));
            SalesManager page = new SalesManager();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillSeniorAccountant()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", SeniorAccountant.Name));

            PropertiesCollection.OpenBrowser(ApplicationForm.Url(SeniorAccountant.JobAlias));
            SeniorAccountant page = new SeniorAccountant();

            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());

            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillWorkAndStudy()
        {
            Console.WriteLine(string.Format("{0} New Applicant Process Test", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(ApplicationForm.Url(WorkAndStudy.JobAlias));
            WorkAndStudy page = new WorkAndStudy();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillWebDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", WebDeveloper.Name));
            PropertiesCollection.OpenBrowser(WebDeveloper.Url);
            WebDeveloper page = new WebDeveloper();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillWebDesigner()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", WebDesigner.Name));
            PropertiesCollection.OpenBrowser(WebDesigner.Url);
            WebDesigner page = new WebDesigner();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillUiDesigner()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", UiDesigner.Name));
            PropertiesCollection.OpenBrowser(UiDesigner.Url);
            UiDesigner page = new UiDesigner();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillPhpDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", PhpDeveloper.Name));
            PropertiesCollection.OpenBrowser(PhpDeveloper.Url);
            PhpDeveloper page = new PhpDeveloper();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillJavaDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", JavaDeveloper.Name));
            PropertiesCollection.OpenBrowser(JavaDeveloper.Url);
            JavaDeveloper page = new JavaDeveloper();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillITManager()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", ItManager.Name));
            PropertiesCollection.OpenBrowser(ItManager.Url);
            ItManager page = new ItManager();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillArtManager()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", ArtDirector.Name));
            PropertiesCollection.OpenBrowser(ArtDirector.Url);
            ArtDirector page = new ArtDirector();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }

        [TestMethod]
        public void ApplicantMandatoryFillAndroidDeveloper()
        {
            Console.WriteLine(string.Format("{0} Applicant Mandatory Fill", AndroidDeveloper.Name));
            PropertiesCollection.OpenBrowser(AndroidDeveloper.Url);
            AndroidDeveloper page = new AndroidDeveloper();
            if (page.ApplicantMandatoryFill())
            {
            };

            //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            PropertiesCollection.driver.Quit();
        }
    }
}

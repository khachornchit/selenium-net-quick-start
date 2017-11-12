using Selenium2016.Models;
using Selenium2016.Models.NewDesigned;
using Selenium2016.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUtilities;
using System;

namespace Selenium2016.Tests
{
    [TestClass]
    public class InteressentMandatoryFill
    {
        [TestInitialize]
        public void DefineDefaultBrowser()
        {
            PropertiesCollection.SetDefaultBrowserChrome();
        }

        [TestMethod]
        public void ShortAdministrativeAssistant()
        {
            Console.WriteLine(string.Format("Interessent {0}", AdministrativeAssistant.Name));
            PropertiesCollection.OpenBrowser(AdministrativeAssistant.Url);
            AdministrativeAssistant page = new AdministrativeAssistant();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeEnglish()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeEnglish.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeEnglish.Url);
            CustomerCareRepresentativeEnglish page = new CustomerCareRepresentativeEnglish();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeFrench()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeFrench.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeFrench.Url);
            CustomerCareRepresentativeFrench page = new CustomerCareRepresentativeFrench();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeGerman()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeGerman.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeGerman.Url);
            CustomerCareRepresentativeGerman page = new CustomerCareRepresentativeGerman();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeItalian()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeItalian.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeItalian.Url);
            CustomerCareRepresentativeItalian page = new CustomerCareRepresentativeItalian();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeSpanish()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeSpanish.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeSpanish.Url);
            CustomerCareRepresentativeSpanish page = new CustomerCareRepresentativeSpanish();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeSwiss()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeSwiss.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeSwiss.Url);
            CustomerCareRepresentativeSwiss page = new CustomerCareRepresentativeSwiss();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortCustomerCareRepresentativeThai()
        {
            Console.WriteLine(string.Format("Interessent {0}", CustomerCareRepresentativeThai.Name));
            PropertiesCollection.OpenBrowser(CustomerCareRepresentativeThai.Url);
            CustomerCareRepresentativeThai page = new CustomerCareRepresentativeThai();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortOfficeAssistant()
        {
            Console.WriteLine(string.Format("Interessent {0}", OfficeAssistant.Name));
            PropertiesCollection.OpenBrowser(OfficeAssistant.Url);
            OfficeAssistant page = new OfficeAssistant();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesAgentEnglish()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesAgentEnglish.Name));
            PropertiesCollection.OpenBrowser(SalesAgentEnglish.Url);
            SalesAgentEnglish page = new SalesAgentEnglish();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesAgentFrench()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesAgentFrench.Name));
            PropertiesCollection.OpenBrowser(SalesAgentFrench.Url);
            SalesAgentFrench page = new SalesAgentFrench();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesAgentGerman()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesAgentGerman.Name));
            PropertiesCollection.OpenBrowser(SalesAgentGerman.Url);
            SalesAgentGerman page = new SalesAgentGerman();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesAgentItalian()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesAgentItalian.Name));
            PropertiesCollection.OpenBrowser(SalesAgentItalian.Url);
            SalesAgentItalian page = new SalesAgentItalian();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesAgentJapanese()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesAgentJapanese.Name));
            PropertiesCollection.OpenBrowser(SalesAgentJapanese.Url);
            SalesAgentJapanese page = new SalesAgentJapanese();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesAgentThai()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesAgentThai.Name));
            PropertiesCollection.OpenBrowser(SalesAgentThai.Url);
            SalesAgentThai page = new SalesAgentThai();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSalesManager()
        {
            Console.WriteLine(string.Format("Interessent {0}", SalesManager.Name));
            PropertiesCollection.OpenBrowser(SalesManager.Url);
            SalesManager page = new SalesManager();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortSeniorAccountant()
        {
            Console.WriteLine(string.Format("Interessent {0}", SeniorAccountant.Name));
            PropertiesCollection.OpenBrowser(SeniorAccountant.Url);
            SeniorAccountant page = new SeniorAccountant();

            if (page.InteressentMandatoryFill())
            {
                //foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortWorkAndStudyTop()
        {
            Console.WriteLine(string.Format("Interessent {0} (TOP)", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(WorkAndStudy.Url);
            WorkAndStudy page = new WorkAndStudy();

            if (page.InteressentMandatoryFillTop())
            {
                foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }

        //[TestMethod]
        public void ShortWorkAndStudyBottom()
        {
            Console.WriteLine(string.Format("Interessent {0} (BOTTOM)", WorkAndStudy.Name));
            PropertiesCollection.OpenBrowser(WorkAndStudy.Url);
            WorkAndStudy page = new WorkAndStudy();

            if (page.InteressentMandatoryFillBottom())
            {
                foreach (TestResultInPage result in page.TestResultInPages) Console.WriteLine(result.Report());
            }

            PropertiesCollection.driver.Quit();
        }
    }
}

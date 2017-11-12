using Selenium2016.Process;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumUtilities;
using System;
using System.Collections.Generic;

namespace Selenium2016.Models
{
    public class WorkAndStudy : IApplicantProcess
    {
        public static string Name { get { return "Work And Study"; } }
        public List<TestResultInPage> TestResultInPages { get; set; }
        private string TestName { get; set; }
        public static string Url { get { return "http://www.clbs.co.th/work-and-study.html"; } }
        public static string JobName { get { return Name; } }
        public static string JobAlias { get { return "wasprogram"; } }

        public WorkAndStudy()
        {
            TestResultInPages = new List<TestResultInPage>();
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        #region Top Form Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='select_lang']")]
        protected IWebElement topLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation']")]
        protected IWebElement topTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name']")]
        protected IWebElement topFirtName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name']")]
        protected IWebElement topLastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email1']")]
        protected IWebElement topEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phonePopup177']/div/input")]
        protected IWebElement topTelephone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c']")]
        protected IWebElement topNationality { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='btn-submit-form']")]
        protected IWebElement topSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='onepage-content']/div[3]/div[1]/div[3]/div[1]/section/div/div[2]/h3")]
        protected IWebElement topThankyou { get; set; }
        #endregion

        #region Top Form Validation
        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation-error']")]
        protected IWebElement topValidationTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name-error']")]
        protected IWebElement topValidationFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name-error']")]
        protected IWebElement topValidationLastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email1-error']")]
        protected IWebElement topValidationEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c-error']")]
        protected IWebElement topValidationNationality { get; set; }
        #endregion

        #region Bottom Form Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='select_lang1']")]
        protected IWebElement bottomLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation1']")]
        protected IWebElement bottomTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name1']")]
        protected IWebElement bottomFirtName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name1']")]
        protected IWebElement bottomLastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email2']")]
        protected IWebElement bottomEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phonePopup181']/div/input")]
        protected IWebElement bottomTelephone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_1']")]
        protected IWebElement bottomNationality { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='btn-submit-form1']")]
        protected IWebElement bottomSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='content-stay-box']/div[3]/div[2]/div[2]/div[1]/section/div/div[2]/h3")]
        protected IWebElement bottomThankyou { get; set; }
        #endregion

        #region Bottom Form Validation
        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation1-error']")]
        protected IWebElement bottomValidationTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name1-error']")]
        protected IWebElement bottomValidationFirtName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name1-error']")]
        protected IWebElement bottomValidationLastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email2-error']")]
        protected IWebElement bottomValidationEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_1-error']")]
        protected IWebElement bottomValidationNationality { get; set; }
        #endregion

        #region Main Process
        public bool InteressentMandatoryTest()
        {
            try
            {
                while (!ReadyPage()) ;
                topSubmit.Submit();
                PropertiesCollection.Sleep100();
                MandatoryTestTopTitle();
                MandatoryTestTopFirstName();
                MandatoryTestTopLastName();
                MandatoryTestTopNationality();

                bottomSubmit.Submit();
                PropertiesCollection.Sleep100();
                MandatoryTestBottomFirstName();
                MandatoryTestBottomLastName();
                MandatoryTestBottomNationality();

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool InteressentMandatoryFill()
        {
            throw new NotImplementedException();
        }

        public bool InteressentMandatoryFillTop()
        {
            TestName = string.Format("Interessent {0} (Top)", Name);
            try
            {
                while (!ReadyPage()) ;
                InteressentInfo interessentInfoTop = new InteressentInfo(LanguagesGermanVersion.Spanisch, Titles.Mr, "Interessent Work and Study (Top)", "Interessent Work and Study (Top)", Emails.HrmTest, Nationalities.Spanish);
                topLanguage.SendKeys(interessentInfoTop.Language);
                topTitle.SendKeys(interessentInfoTop.Title);
                topFirtName.EnterText(interessentInfoTop.FirstName);
                topLastName.EnterText(interessentInfoTop.LastName);
                topEmail.EnterText(interessentInfoTop.Email);
                topNationality.SendKeys(interessentInfoTop.Nationality);
                topSubmit.Click();

                while (!ReadyThankyouTop()) ;
                TestResultInPages.Add(new TestResultInPage(TestName, true));

                return true;
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        public bool InteressentMandatoryFillBottom()
        {
            TestName = string.Format("Interessent {0} (Bottom)", Name);
            try
            {
                while (!ReadyPage()) ;
                InteressentInfo interessentInfoBottom = new InteressentInfo(LanguagesGermanVersion.Englisch, Titles.Mr, "Interessent Work and Study (Bottom)", "Interessent Work and Study (Bottom)", Emails.HrmTest, Nationalities.Spanish);
                bottomLanguage.SendKeys(interessentInfoBottom.Language);
                bottomTitle.SendKeys(interessentInfoBottom.Title);
                bottomFirtName.EnterText(interessentInfoBottom.FirstName);
                bottomLastName.EnterText(interessentInfoBottom.LastName);
                bottomEmail.EnterText(interessentInfoBottom.Email);
                bottomNationality.SendKeys(interessentInfoBottom.Nationality);
                PropertiesCollection.Sleep500();
                bottomSubmit.Click();

                PropertiesCollection.Sleep500();
                while (!ReadyThankyouBottom()) ;
                TestResultInPages.Add(new TestResultInPage(TestName, true));

                return true;
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        public bool ApplicantMandatoryTest()
        {
            throw new NotImplementedException();
        }

        public bool ApplicantMandatoryFill()
        {
            ApplicationForm page = new ApplicationForm(JobName, JobAlias);
            if (page.ApplicantMandatoryFill())
            {
                TestResultInPages.Add(new TestResultInPage(TestName, true));
            }
            else
            {
                TestResultInPages.Add(new TestResultInPage(TestName, "Failed", false));
            }

            return true;
        }

        public ApplicationForm NewApplicantProcessPage1()
        {
            ApplicationForm page = new ApplicationForm(JobName, JobAlias);
            try
            {
                page.ApplicationPage1();
                return page;
            } catch (Exception)
            {
                return page;
            }
        }
        #endregion

        #region Sub Process Mandatory Test
        public bool ReadyPage()
        {
            try
            {
                return bottomSubmit.Displayed;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        private void MandatoryTestTopTitle()
        {
            TestName = string.Format("{0} - Mandatory Test Title (TOP)", Name);
            try
            {
                if (topValidationTitle.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, topValidationTitle.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestTopFirstName()
        {
            TestName = string.Format("{0} - Mandatory Test First Name (TOP)", Name);
            try
            {
                if (topValidationFirstName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, topValidationFirstName.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestTopLastName()
        {
            TestName = string.Format("{0} - Mandatory Test Last Name (TOP)", Name);
            try
            {
                if (topValidationLastName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, topValidationLastName.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestTopEmail()
        {
            TestName = string.Format("{0} - Mandatory Test Email (TOP)", Name);
            try
            {
                if (topValidationEmail.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, topValidationEmail.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestTopNationality()
        {
            TestName = string.Format("{0} - Mandatory Test Nationality (TOP)", Name);
            try
            {
                if (topValidationNationality.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, topValidationNationality.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestBottomFirstName()
        {
            TestName = string.Format("{0} - Mandatory Test First Name (BOTTOM)", Name);
            try
            {
                if (bottomValidationFirtName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, bottomValidationFirtName.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestBottomLastName()
        {
            TestName = string.Format("{0} - Mandatory Test Last Name (BOTTOM)", Name);
            try
            {
                if (bottomValidationLastName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, bottomValidationLastName.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestBottomEmail()
        {
            TestName = string.Format("{0} - Mandatory Test Email (BOTTOM)", Name);
            try
            {
                if (bottomValidationEmail.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, bottomValidationEmail.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }

        private void MandatoryTestBottomNationality()
        {
            TestName = string.Format("{0} - Mandatory Test Nationality (BOTTOM)", Name);
            try
            {
                if (bottomValidationNationality.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, bottomValidationNationality.Displayed));
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
            }
        }
        #endregion

        #region Sub Process Thank you
        private bool ReadyThankyouTop()
        {
            try
            {
                return topThankyou.IsInnerHtml("Thank you.");
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ReadyThankyouBottom()
        {
            try
            {
                return bottomThankyou.IsInnerHtml("Thank you");
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Interessent Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='select_lang']")]
        protected IWebElement Language { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation']")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name']")]
        protected IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name']")]
        protected IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email1']")]
        protected IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phone_work']")]
        protected IWebElement Telephone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/a")]
        protected IWebElement Nationality { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='btn-submit-form']")]
        protected IWebElement Submit { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='successmessage']/h3")]
        protected IWebElement Thankyou { get; set; }
        #endregion

        #region Nationalities Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='British']")]
        protected IWebElement page1NationalityBritish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='French']")]
        protected IWebElement page1NationalityFrench { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='German']")]
        protected IWebElement page1NationalityGerman { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Italian']")]
        protected IWebElement page1NationalityItalian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Spanish']")]
        protected IWebElement page1NationalitySpanish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Thai']")]
        protected IWebElement page1NationalityThai { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Afghan']")]
        protected IWebElement page1NationalityAfghan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Albanian']")]
        protected IWebElement page1NationalityAlbanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Algerian']")]
        protected IWebElement page1NationalityAlgerian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='American']")]
        protected IWebElement page1NationalityAmerican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Andorran']")]
        protected IWebElement page1NationalityAndorran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Angolan']")]
        protected IWebElement page1NationalityAngolan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Antiguans']")]
        protected IWebElement page1NationalityAntiguans { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Argentinean']")]
        protected IWebElement page1NationalityArgentinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Armenian']")]
        protected IWebElement page1NationalityArmenian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Australian']")]
        protected IWebElement page1NationalityAustralian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Austrian']")]
        protected IWebElement page1NationalityAustrian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Azerbaijani']")]
        protected IWebElement page1NationalityAzerbaijani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bahamian']")]
        protected IWebElement page1NationalityBahamian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bahraini']")]
        protected IWebElement page1NationalityBahraini { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bangladeshi']")]
        protected IWebElement page1NationalityBangladeshi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Barbadian']")]
        protected IWebElement page1NationalityBarbadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Barbudans']")]
        protected IWebElement page1NationalityBarbudans { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Batswana']")]
        protected IWebElement page1NationalityBatswana { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Belarusian']")]
        protected IWebElement page1NationalityBelarusian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Belgian']")]
        protected IWebElement page1NationalityBelgian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Belizean']")]
        protected IWebElement page1NationalityBelizean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Beninese']")]
        protected IWebElement page1NationalityBeninese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bhutanese']")]
        protected IWebElement page1NationalityBhutanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bolivian']")]
        protected IWebElement page1NationalityBolivian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bosnian']")]
        protected IWebElement page1NationalityBosnian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Brazilian']")]
        protected IWebElement page1NationalityBrazilian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bruneian']")]
        protected IWebElement page1NationalityBruneian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bulgarian']")]
        protected IWebElement page1NationalityBulgarian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Burkinabe']")]
        protected IWebElement page1NationalityBurkinabe { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Burmese']")]
        protected IWebElement page1NationalityBurmese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Burundian']")]
        protected IWebElement page1NationalityBurundian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cambodian']")]
        protected IWebElement page1NationalityCambodian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cameroonian']")]
        protected IWebElement page1NationalityCameroonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Canadian']")]
        protected IWebElement page1NationalityCanadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cape Verdean']")]
        protected IWebElement page1NationalityCapeVerdean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Central African']")]
        protected IWebElement page1NationalityCentralAfrican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Chadian']")]
        protected IWebElement page1NationalityChadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Chilean']")]
        protected IWebElement page1NationalityChilean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Chinese']")]
        protected IWebElement page1NationalityChinese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Colombian']")]
        protected IWebElement page1NationalityColombian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Comoran']")]
        protected IWebElement page1NationalityComoran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Congolese']")]
        protected IWebElement page1NationalityCongolese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Costa Rican']")]
        protected IWebElement page1NationalityCostaRican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Croatian']")]
        protected IWebElement page1NationalityCroatian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cuban']")]
        protected IWebElement page1NationalityCuban { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cypriot']")]
        protected IWebElement page1NationalityCypriot { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Czech']")]
        protected IWebElement page1NationalityCzech { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Danish']")]
        protected IWebElement page1NationalityDanish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Djibouti']")]
        protected IWebElement page1NationalityDjibouti { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Dominican']")]
        protected IWebElement page1NationalityDominican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Dutch']")]
        protected IWebElement page1NationalityDutch { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='East Timorese']")]
        protected IWebElement page1NationalityEastTimorese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ecuadorean']")]
        protected IWebElement page1NationalityEcuadorean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Egyptian']")]
        protected IWebElement page1NationalityEgyptian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Emirian']")]
        protected IWebElement page1NationalityEmirian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Equatorial Guinean']")]
        protected IWebElement page1NationalityEquatorialGuinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Eritrean']")]
        protected IWebElement page1NationalityEritrean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Estonian']")]
        protected IWebElement page1NationalityEstonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ethiopian']")]
        protected IWebElement page1NationalityEthiopian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Fijian']")]
        protected IWebElement page1NationalityFijian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Filipino']")]
        protected IWebElement page1NationalityFilipino { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Finnish']")]
        protected IWebElement page1NationalityFinnish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Gabonese']")]
        protected IWebElement page1NationalityGabonese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Gambian']")]
        protected IWebElement page1NationalityGambian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Georgian']")]
        protected IWebElement page1NationalityGeorgian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ghanaian']")]
        protected IWebElement page1NationalityGhanaian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Greek']")]
        protected IWebElement page1NationalityGreek { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Grenadian']")]
        protected IWebElement page1NationalityGrenadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guatemalan']")]
        protected IWebElement page1NationalityGuatemalan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guinea-Bissauan']")]
        protected IWebElement page1NationalityGuineaBissauan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guinean']")]
        protected IWebElement page1NationalityGuinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guyanese']")]
        protected IWebElement page1NationalityGuyanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Haitian']")]
        protected IWebElement page1NationalityHaitian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Herzegovinian']")]
        protected IWebElement page1NationalityHerzegovinian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Honduran']")]
        protected IWebElement page1NationalityHonduran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Hungarian']")]
        protected IWebElement page1NationalityHungarian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='I-Kiribati']")]
        protected IWebElement page1NationalityIKiribati { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Icelander']")]
        protected IWebElement page1NationalityIcelander { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Indian']")]
        protected IWebElement page1NationalityIndian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Indonesian']")]
        protected IWebElement page1NationalityIndonesian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Iranian']")]
        protected IWebElement page1NationalityIranian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Iraqi']")]
        protected IWebElement page1NationalityIraqi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Irish']")]
        protected IWebElement page1NationalityIrish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Israeli']")]
        protected IWebElement page1NationalityIsraeli { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ivorian']")]
        protected IWebElement page1NationalityIvorian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Jamaican']")]
        protected IWebElement page1NationalityJamaican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Japanese']")]
        protected IWebElement page1NationalityJapanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Jordanian']")]
        protected IWebElement page1NationalityJordanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kazakhstani']")]
        protected IWebElement page1NationalityKazakhstani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kenyan']")]
        protected IWebElement page1NationalityKenyan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kittian and Nevisian']")]
        protected IWebElement page1NationalityKittianAndNevisian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kuwaiti']")]
        protected IWebElement page1NationalityKuwaiti { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kyrgyz']")]
        protected IWebElement page1NationalityKyrgyz { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Laotian']")]
        protected IWebElement page1NationalityLaotian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Latvian']")]
        protected IWebElement page1NationalityLatvian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Lebanese']")]
        protected IWebElement page1NationalityLebanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Liberian']")]
        protected IWebElement page1NationalityLiberian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Libyan']")]
        protected IWebElement page1NationalityLibyan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Liechtensteiner']")]
        protected IWebElement page1NationalityLiechtensteiner { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Lithuanian']")]
        protected IWebElement page1NationalityLithuanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Luxembourger']")]
        protected IWebElement page1NationalityLuxembourger { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Macedonian']")]
        protected IWebElement page1NationalityMacedonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malagasy']")]
        protected IWebElement page1NationalityMalagasy { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malawian']")]
        protected IWebElement page1NationalityMalawian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malaysian']")]
        protected IWebElement page1NationalityMalaysian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Maldivan']")]
        protected IWebElement page1NationalityMaldivan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malian']")]
        protected IWebElement page1NationalityMalian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Maltese']")]
        protected IWebElement page1NationalityMaltese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Marshallese']")]
        protected IWebElement page1NationalityMarshallese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mauritanian']")]
        protected IWebElement page1NationalityMauritanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mauritian']")]
        protected IWebElement page1NationalityMauritian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mexican']")]
        protected IWebElement page1NationalityMexican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Micronesian']")]
        protected IWebElement page1NationalityMicronesian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Moldovan']")]
        protected IWebElement page1NationalityMoldovan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Monacan']")]
        protected IWebElement page1NationalityMonacan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mongolian']")]
        protected IWebElement page1NationalityMongolian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Moroccan']")]
        protected IWebElement page1NationalityMoroccan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mosotho']")]
        protected IWebElement page1NationalityMosotho { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Motswana']")]
        protected IWebElement page1NationalityMotswana { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mozambican']")]
        protected IWebElement page1NationalityMozambican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Namibian']")]
        protected IWebElement page1NationalityNamibian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nauruan']")]
        protected IWebElement page1NationalityNauruan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nepalese']")]
        protected IWebElement page1NationalityNepalese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='New Zealander']")]
        protected IWebElement page1NationalityNewZealander { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nicaraguan']")]
        protected IWebElement page1NationalityNicaraguan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nigerian']")]
        protected IWebElement page1NationalityNigerian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nigerien']")]
        protected IWebElement page1NationalityNigerien { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='North Korean']")]
        protected IWebElement page1NationalityNorthKorean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Northern Irish']")]
        protected IWebElement page1NationalityNorthernIrish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Norwegian']")]
        protected IWebElement page1NationalityNorwegian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Omani']")]
        protected IWebElement page1NationalityOmani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Pakistani']")]
        protected IWebElement page1NationalityPakistani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Palauan']")]
        protected IWebElement page1NationalityPalauan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Panamanian']")]
        protected IWebElement page1NationalityPanamanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Papua New Guinean']")]
        protected IWebElement page1NationalityPapuaNewGuinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Paraguayan']")]
        protected IWebElement page1NationalityParaguayan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Peruvian']")]
        protected IWebElement page1NationalityPeruvian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Polish']")]
        protected IWebElement page1NationalityPolish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Portuguese']")]
        protected IWebElement page1NationalityPortuguese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Qatari']")]
        protected IWebElement page1NationalityQatari { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Romanian']")]
        protected IWebElement page1NationalityRomanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Russian']")]
        protected IWebElement page1NationalityRussian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Rwandan']")]
        protected IWebElement page1NationalityRwandan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Saint Lucian']")]
        protected IWebElement page1NationalitySaintLucian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Salvadoran']")]
        protected IWebElement page1NationalitySalvadoran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Samoan']")]
        protected IWebElement page1NationalitySamoan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='San Marinese']")]
        protected IWebElement page1NationalitySanMarinese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sao Tomean']")]
        protected IWebElement page1NationalitySaoTomean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Saudi']")]
        protected IWebElement page1NationalitySaudi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Scottish']")]
        protected IWebElement page1NationalityScottish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Senegalese']")]
        protected IWebElement page1NationalitySenegalese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Serbian']")]
        protected IWebElement page1NationalitySerbian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Seychellois']")]
        protected IWebElement page1NationalitySeychellois { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sierra Leonean']")]
        protected IWebElement page1NationalitySierraLeonean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Singaporean']")]
        protected IWebElement page1NationalitySingaporean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Slovakian']")]
        protected IWebElement page1NationalitySlovakian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Slovenian']")]
        protected IWebElement page1NationalitySlovenian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Solomon Islander']")]
        protected IWebElement page1NationalitySolomonIslander { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Somali']")]
        protected IWebElement page1NationalitySomali { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='South African']")]
        protected IWebElement page1NationalitySouthAfrican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='South Korean']")]
        protected IWebElement page1NationalitySouthKorean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sri Lankan']")]
        protected IWebElement page1NationalitySriLankan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sudanese']")]
        protected IWebElement page1NationalitySudanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Surinamer']")]
        protected IWebElement page1NationalitySurinamer { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Swazi']")]
        protected IWebElement page1NationalitySwazi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Swedish']")]
        protected IWebElement page1NationalitySwedish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Swiss']")]
        protected IWebElement page1NationalitySwiss { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Syrian']")]
        protected IWebElement page1NationalitySyrian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Taiwanese']")]
        protected IWebElement page1NationalityTaiwanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tajik']")]
        protected IWebElement page1NationalityTajik { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tanzanian']")]
        protected IWebElement page1NationalityTanzanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Togolese']")]
        protected IWebElement page1NationalityTogolese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tongan']")]
        protected IWebElement page1NationalityTongan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Trinidadian or Tobagonian']")]
        protected IWebElement page1NationalityTrinidadianOrTobagonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tunisian']")]
        protected IWebElement page1NationalityTunisian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Turkish']")]
        protected IWebElement page1NationalityTurkish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tuvaluan']")]
        protected IWebElement page1NationalityTuvaluan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ugandan']")]
        protected IWebElement page1NationalityUgandan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ukrainian']")]
        protected IWebElement page1NationalityUkrainian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Uruguayan']")]
        protected IWebElement page1NationalityUruguayan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Uzbekistani']")]
        protected IWebElement page1NationalityUzbekistani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Venezuelan']")]
        protected IWebElement page1NationalityVenezuelan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Vietnamese']")]
        protected IWebElement page1NationalityVietnamese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Welsh']")]
        protected IWebElement page1NationalityWelsh { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Yemenite']")]
        protected IWebElement page1NationalityYemenite { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Zambian']")]
        protected IWebElement page1NationalityZambian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Zimbabwean']")]
        protected IWebElement page1NationalityZimbabwean { get; set; }
        #endregion

        #region Ready Page

        private bool ReadyThankyou()
        {
            try
            {
                return Thankyou.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}

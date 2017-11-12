using Selenium2016.Process;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumUtilities;
using System;
using System.Collections.Generic;

namespace Selenium2016.Models.NewDesigned
{
    public class WebDesigner: IApplicantProcess
    {
        public static string Name { get { return "Web Designer"; } }
        public List<TestResultInPage> TestResultInPages { get; set; }
        private string TestName { get; set; }
        public static string Url { get { return "http://www.clbs.co.th/lp/web-designer.html"; } }
        public static string JobName { get { return Name; } }
        public static string JobAlias { get { return "None"; } }

        public WebDesigner()
        {
            TestResultInPages = new List<TestResultInPage>();
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        #region Mandatory Fields

        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation']")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name']")]
        protected IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name']")]
        protected IWebElement SureName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email1']")]
        protected IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phone_work']")]
        protected IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/a")]
        protected IWebElement Nationality { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='fileupload_CV']")]
        protected IWebElement Resume { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='form-apply']/div[2]/div/input")]
        protected IWebElement ApplyNow { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='apply']/article/div/div/div[4]/div/div[1]/h3")]
        protected IWebElement Thankyou { get; set; }
        #endregion

        #region Validation Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation-error']")]
        protected IWebElement ValidationTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name-error']")]
        protected IWebElement ValidationName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name-error']")]
        protected IWebElement ValidationSureName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email1-error']")]
        protected IWebElement ValidationEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phone_work-error']")]
        protected IWebElement ValidationPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c-error']")]
        protected IWebElement ValidationNationality { get; set; }

        #endregion

        #region Main Process
        public bool InteressentMandatoryTest()
        {
            throw new NotImplementedException();
        }

        public bool InteressentMandatoryFill()
        {
            throw new NotImplementedException();
        }

        public bool ApplicantMandatoryTest()
        {
            try
            {
                while (!ReadyPage()) ;

                ApplyNow.Click();

                MandatoryTestTitle();
                MandatoryTestName();
                MandatoryTestSureName();
                MandatoryTestEmail();
                MandatoryTestPhoneNumber();
                MandatoryTestNationality();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ApplicantMandatoryFill()
        {
            try
            {
                while (!ReadyPage()) ;

                Title.SendKeys(Titles.Prof);
                FirstName.EnterText(string.Format("{0}", Name));
                SureName.EnterText(string.Format("{0}", Name));
                Email.EnterText(Emails.HrmTest);
                PhoneNumber.EnterText("081-2564459");

                Nationality.Click();
                PropertiesCollection.Sleep500();
                NationalityGerman.Click();
                PropertiesCollection.Sleep100();

                ApplyNow.Click();
                while (!ReadyThankyou()) ;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Ready Page
        private bool ReadyPage()
        {
            try
            {
                return ApplyNow.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool ReadyThankyou()
        {
            try
            {
                return Thankyou.IsInnerHtml("Thank you");
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Mandatory Test
        private bool MandatoryTestTitle()
        {
            TestName = string.Format("{0} - Mandatory Test Title", Name);
            try
            {
                if (ValidationTitle.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, ValidationTitle.Displayed));
                    return true;
                }
                else
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, false));
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        private bool MandatoryTestName()
        {
            TestName = string.Format("{0} - Mandatory Test First Name", Name);
            try
            {
                if (ValidationName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, ValidationName.Displayed));
                    return true;
                }
                else
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, false));
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        private bool MandatoryTestSureName()
        {
            TestName = string.Format("{0} - Mandatory Test Sure Name", Name);
            try
            {
                if (ValidationSureName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, ValidationSureName.Displayed));
                    return true;
                }
                else
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, false));
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        private bool MandatoryTestEmail()
        {
            TestName = string.Format("{0} - Mandatory Test Email", Name);
            try
            {
                if (ValidationEmail.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, ValidationEmail.Displayed));
                    return true;
                }
                else
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, false));
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        private bool MandatoryTestPhoneNumber()
        {
            TestName = string.Format("{0} - Mandatory Test First Name", Name);
            try
            {
                if (ValidationName.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, ValidationName.Displayed));
                    return true;
                }
                else
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, false));
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        private bool MandatoryTestNationality()
        {
            TestName = string.Format("{0} - Mandatory Test Nationality", Name);
            try
            {
                if (ValidationNationality.Displayed)
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, ValidationNationality.Displayed));
                    return true;
                }
                else
                {
                    TestResultInPages.Add(new TestResultInPage(TestName, false));
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                TestResultInPages.Add(new TestResultInPage(TestName, ex.Message, false));
                return false;
            }
        }

        #endregion

        #region Nationalities Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='British']")]
        protected IWebElement NationalityBritish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='French']")]
        protected IWebElement NationalityFrench { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='German']")]
        protected IWebElement NationalityGerman { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Italian']")]
        protected IWebElement NationalityItalian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Spanish']")]
        protected IWebElement NationalitySpanish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Thai']")]
        protected IWebElement NationalityThai { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Afghan']")]
        protected IWebElement NationalityAfghan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Albanian']")]
        protected IWebElement NationalityAlbanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Algerian']")]
        protected IWebElement NationalityAlgerian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='American']")]
        protected IWebElement NationalityAmerican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Andorran']")]
        protected IWebElement NationalityAndorran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Angolan']")]
        protected IWebElement NationalityAngolan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Antiguans']")]
        protected IWebElement NationalityAntiguans { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Argentinean']")]
        protected IWebElement NationalityArgentinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Armenian']")]
        protected IWebElement NationalityArmenian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Australian']")]
        protected IWebElement NationalityAustralian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Austrian']")]
        protected IWebElement NationalityAustrian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Azerbaijani']")]
        protected IWebElement NationalityAzerbaijani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bahamian']")]
        protected IWebElement NationalityBahamian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bahraini']")]
        protected IWebElement NationalityBahraini { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bangladeshi']")]
        protected IWebElement NationalityBangladeshi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Barbadian']")]
        protected IWebElement NationalityBarbadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Barbudans']")]
        protected IWebElement NationalityBarbudans { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Batswana']")]
        protected IWebElement NationalityBatswana { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Belarusian']")]
        protected IWebElement NationalityBelarusian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Belgian']")]
        protected IWebElement NationalityBelgian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Belizean']")]
        protected IWebElement NationalityBelizean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Beninese']")]
        protected IWebElement NationalityBeninese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bhutanese']")]
        protected IWebElement NationalityBhutanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bolivian']")]
        protected IWebElement NationalityBolivian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bosnian']")]
        protected IWebElement NationalityBosnian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Brazilian']")]
        protected IWebElement NationalityBrazilian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bruneian']")]
        protected IWebElement NationalityBruneian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Bulgarian']")]
        protected IWebElement NationalityBulgarian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Burkinabe']")]
        protected IWebElement NationalityBurkinabe { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Burmese']")]
        protected IWebElement NationalityBurmese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Burundian']")]
        protected IWebElement NationalityBurundian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cambodian']")]
        protected IWebElement NationalityCambodian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cameroonian']")]
        protected IWebElement NationalityCameroonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Canadian']")]
        protected IWebElement NationalityCanadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cape Verdean']")]
        protected IWebElement NationalityCapeVerdean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Central African']")]
        protected IWebElement NationalityCentralAfrican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Chadian']")]
        protected IWebElement NationalityChadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Chilean']")]
        protected IWebElement NationalityChilean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Chinese']")]
        protected IWebElement NationalityChinese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Colombian']")]
        protected IWebElement NationalityColombian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Comoran']")]
        protected IWebElement NationalityComoran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Congolese']")]
        protected IWebElement NationalityCongolese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Costa Rican']")]
        protected IWebElement NationalityCostaRican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Croatian']")]
        protected IWebElement NationalityCroatian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cuban']")]
        protected IWebElement NationalityCuban { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Cypriot']")]
        protected IWebElement NationalityCypriot { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Czech']")]
        protected IWebElement NationalityCzech { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Danish']")]
        protected IWebElement NationalityDanish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Djibouti']")]
        protected IWebElement NationalityDjibouti { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Dominican']")]
        protected IWebElement NationalityDominican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Dutch']")]
        protected IWebElement NationalityDutch { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='East Timorese']")]
        protected IWebElement NationalityEastTimorese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ecuadorean']")]
        protected IWebElement NationalityEcuadorean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Egyptian']")]
        protected IWebElement NationalityEgyptian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Emirian']")]
        protected IWebElement NationalityEmirian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Equatorial Guinean']")]
        protected IWebElement NationalityEquatorialGuinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Eritrean']")]
        protected IWebElement NationalityEritrean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Estonian']")]
        protected IWebElement NationalityEstonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ethiopian']")]
        protected IWebElement NationalityEthiopian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Fijian']")]
        protected IWebElement NationalityFijian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Filipino']")]
        protected IWebElement NationalityFilipino { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Finnish']")]
        protected IWebElement NationalityFinnish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Gabonese']")]
        protected IWebElement NationalityGabonese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Gambian']")]
        protected IWebElement NationalityGambian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Georgian']")]
        protected IWebElement NationalityGeorgian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ghanaian']")]
        protected IWebElement NationalityGhanaian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Greek']")]
        protected IWebElement NationalityGreek { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Grenadian']")]
        protected IWebElement NationalityGrenadian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guatemalan']")]
        protected IWebElement NationalityGuatemalan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guinea-Bissauan']")]
        protected IWebElement NationalityGuineaBissauan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guinean']")]
        protected IWebElement NationalityGuinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Guyanese']")]
        protected IWebElement NationalityGuyanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Haitian']")]
        protected IWebElement NationalityHaitian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Herzegovinian']")]
        protected IWebElement NationalityHerzegovinian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Honduran']")]
        protected IWebElement NationalityHonduran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Hungarian']")]
        protected IWebElement NationalityHungarian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='I-Kiribati']")]
        protected IWebElement NationalityIKiribati { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Icelander']")]
        protected IWebElement NationalityIcelander { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Indian']")]
        protected IWebElement NationalityIndian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Indonesian']")]
        protected IWebElement NationalityIndonesian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Iranian']")]
        protected IWebElement NationalityIranian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Iraqi']")]
        protected IWebElement NationalityIraqi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Irish']")]
        protected IWebElement NationalityIrish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Israeli']")]
        protected IWebElement NationalityIsraeli { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ivorian']")]
        protected IWebElement NationalityIvorian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Jamaican']")]
        protected IWebElement NationalityJamaican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Japanese']")]
        protected IWebElement NationalityJapanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Jordanian']")]
        protected IWebElement NationalityJordanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kazakhstani']")]
        protected IWebElement NationalityKazakhstani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kenyan']")]
        protected IWebElement NationalityKenyan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kittian and Nevisian']")]
        protected IWebElement NationalityKittianAndNevisian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kuwaiti']")]
        protected IWebElement NationalityKuwaiti { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Kyrgyz']")]
        protected IWebElement NationalityKyrgyz { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Laotian']")]
        protected IWebElement NationalityLaotian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Latvian']")]
        protected IWebElement NationalityLatvian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Lebanese']")]
        protected IWebElement NationalityLebanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Liberian']")]
        protected IWebElement NationalityLiberian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Libyan']")]
        protected IWebElement NationalityLibyan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Liechtensteiner']")]
        protected IWebElement NationalityLiechtensteiner { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Lithuanian']")]
        protected IWebElement NationalityLithuanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Luxembourger']")]
        protected IWebElement NationalityLuxembourger { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Macedonian']")]
        protected IWebElement NationalityMacedonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malagasy']")]
        protected IWebElement NationalityMalagasy { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malawian']")]
        protected IWebElement NationalityMalawian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malaysian']")]
        protected IWebElement NationalityMalaysian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Maldivan']")]
        protected IWebElement NationalityMaldivan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Malian']")]
        protected IWebElement NationalityMalian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Maltese']")]
        protected IWebElement NationalityMaltese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Marshallese']")]
        protected IWebElement NationalityMarshallese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mauritanian']")]
        protected IWebElement NationalityMauritanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mauritian']")]
        protected IWebElement NationalityMauritian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mexican']")]
        protected IWebElement NationalityMexican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Micronesian']")]
        protected IWebElement NationalityMicronesian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Moldovan']")]
        protected IWebElement NationalityMoldovan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Monacan']")]
        protected IWebElement NationalityMonacan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mongolian']")]
        protected IWebElement NationalityMongolian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Moroccan']")]
        protected IWebElement NationalityMoroccan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mosotho']")]
        protected IWebElement NationalityMosotho { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Motswana']")]
        protected IWebElement NationalityMotswana { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Mozambican']")]
        protected IWebElement NationalityMozambican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Namibian']")]
        protected IWebElement NationalityNamibian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nauruan']")]
        protected IWebElement NationalityNauruan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nepalese']")]
        protected IWebElement NationalityNepalese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='New Zealander']")]
        protected IWebElement NationalityNewZealander { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nicaraguan']")]
        protected IWebElement NationalityNicaraguan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nigerian']")]
        protected IWebElement NationalityNigerian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Nigerien']")]
        protected IWebElement NationalityNigerien { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='North Korean']")]
        protected IWebElement NationalityNorthKorean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Northern Irish']")]
        protected IWebElement NationalityNorthernIrish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Norwegian']")]
        protected IWebElement NationalityNorwegian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Omani']")]
        protected IWebElement NationalityOmani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Pakistani']")]
        protected IWebElement NationalityPakistani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Palauan']")]
        protected IWebElement NationalityPalauan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Panamanian']")]
        protected IWebElement NationalityPanamanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Papua New Guinean']")]
        protected IWebElement NationalityPapuaNewGuinean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Paraguayan']")]
        protected IWebElement NationalityParaguayan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Peruvian']")]
        protected IWebElement NationalityPeruvian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Polish']")]
        protected IWebElement NationalityPolish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Portuguese']")]
        protected IWebElement NationalityPortuguese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Qatari']")]
        protected IWebElement NationalityQatari { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Romanian']")]
        protected IWebElement NationalityRomanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Russian']")]
        protected IWebElement NationalityRussian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Rwandan']")]
        protected IWebElement NationalityRwandan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Saint Lucian']")]
        protected IWebElement NationalitySaintLucian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Salvadoran']")]
        protected IWebElement NationalitySalvadoran { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Samoan']")]
        protected IWebElement NationalitySamoan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='San Marinese']")]
        protected IWebElement NationalitySanMarinese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sao Tomean']")]
        protected IWebElement NationalitySaoTomean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Saudi']")]
        protected IWebElement NationalitySaudi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Scottish']")]
        protected IWebElement NationalityScottish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Senegalese']")]
        protected IWebElement NationalitySenegalese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Serbian']")]
        protected IWebElement NationalitySerbian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Seychellois']")]
        protected IWebElement NationalitySeychellois { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sierra Leonean']")]
        protected IWebElement NationalitySierraLeonean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Singaporean']")]
        protected IWebElement NationalitySingaporean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Slovakian']")]
        protected IWebElement NationalitySlovakian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Slovenian']")]
        protected IWebElement NationalitySlovenian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Solomon Islander']")]
        protected IWebElement NationalitySolomonIslander { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Somali']")]
        protected IWebElement NationalitySomali { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='South African']")]
        protected IWebElement NationalitySouthAfrican { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='South Korean']")]
        protected IWebElement NationalitySouthKorean { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sri Lankan']")]
        protected IWebElement NationalitySriLankan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Sudanese']")]
        protected IWebElement NationalitySudanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Surinamer']")]
        protected IWebElement NationalitySurinamer { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Swazi']")]
        protected IWebElement NationalitySwazi { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Swedish']")]
        protected IWebElement NationalitySwedish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Swiss']")]
        protected IWebElement NationalitySwiss { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Syrian']")]
        protected IWebElement NationalitySyrian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Taiwanese']")]
        protected IWebElement NationalityTaiwanese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tajik']")]
        protected IWebElement NationalityTajik { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tanzanian']")]
        protected IWebElement NationalityTanzanian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Togolese']")]
        protected IWebElement NationalityTogolese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tongan']")]
        protected IWebElement NationalityTongan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Trinidadian or Tobagonian']")]
        protected IWebElement NationalityTrinidadianOrTobagonian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tunisian']")]
        protected IWebElement NationalityTunisian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Turkish']")]
        protected IWebElement NationalityTurkish { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Tuvaluan']")]
        protected IWebElement NationalityTuvaluan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ugandan']")]
        protected IWebElement NationalityUgandan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Ukrainian']")]
        protected IWebElement NationalityUkrainian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Uruguayan']")]
        protected IWebElement NationalityUruguayan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Uzbekistani']")]
        protected IWebElement NationalityUzbekistani { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Venezuelan']")]
        protected IWebElement NationalityVenezuelan { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Vietnamese']")]
        protected IWebElement NationalityVietnamese { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Welsh']")]
        protected IWebElement NationalityWelsh { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Yemenite']")]
        protected IWebElement NationalityYemenite { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Zambian']")]
        protected IWebElement NationalityZambian { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/div/ul/li[text()='Zimbabwean']")]
        protected IWebElement NationalityZimbabwean { get; set; }

        #endregion

    }
}
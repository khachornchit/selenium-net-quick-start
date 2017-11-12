using Selenium2016.Process;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumUtilities;
using System;
using System.Collections.Generic;

namespace Selenium2016.Models
{
    public class ApplicationForm : IApplicantProcess
    {
        public string Name { get { return string.Format("Application Form - {0}", JobName); } }
        public List<TestResultInPage> TestResultInPages { get; set; }
        private string TestName { get; set; }
        private string JobName { get; set; }
        private string JobAlias { get; set; }

        public static string Url(string JobAlias)
        {
            return string.Format("http://www.clbs.co.th/jobs/application-form.html?job={0}", JobAlias);
        }

        public ApplicationForm(string JobName, string JobAlias)
        {
            this.JobName = JobName;
            this.JobAlias = JobAlias;
            TestResultInPages = new List<TestResultInPage>();
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        #region Page-1 Elements

        [FindsBy(How = How.XPath, Using = ".//*[@id='social-login']/div[1]/div[1]/div/div/div[1]/div/label/input")]
        protected IWebElement page1Facebook { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='social-login']/div[1]/div[1]/div/div/div[2]/div/label/input")]
        protected IWebElement page1Linkedin { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='no-check']")]
        protected IWebElement page1NoThanks { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='social-login']/div[2]/div/a")]
        protected IWebElement page1TopNext { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='form-step1']/div[4]/div/div/input")]
        protected IWebElement page1BottomNext { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='salutation']")]
        protected IWebElement page1Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='first_name']")]
        protected IWebElement page1FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='last_name']")]
        protected IWebElement page1LastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='primary_street_c']")]
        protected IWebElement page1AddressLine1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='primary_address_2']")]
        protected IWebElement page1AddressLine2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='alt_address_postalcode']")]
        protected IWebElement page1ZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='alt_address_city']")]
        protected IWebElement page1City { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/a")]
        protected IWebElement page1Country { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email1']")]
        protected IWebElement page1Email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phone_work']")]
        protected IWebElement page1Telephone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='phone_mobile']")]
        protected IWebElement page1Mobile { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='birthdate']")]
        protected IWebElement page1DateOfBirth { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='nationalitylist_c_chosen']/a/span")]
        protected IWebElement page1Nationality { get; set; }

        #endregion

        #region Countries Elements

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FRANCE']")]
        protected IWebElement page1CountryFrance { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GERMANY']")]
        protected IWebElement page1CountryGermany { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ITALY']")]
        protected IWebElement page1CountryItaly { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SPAIN']")]
        protected IWebElement page1CountrySpain { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='UNITED KINGDOM']")]
        protected IWebElement page1CountryUnitedKingdom { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ABU DHABI']")]
        protected IWebElement page1CountryAbuDhabi { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ADEN']")]
        protected IWebElement page1CountryAden { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='AFGHANISTAN']")]
        protected IWebElement page1CountryAfghanistan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ALBANIA']")]
        protected IWebElement page1CountryAlbania { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ALGERIA']")]
        protected IWebElement page1CountryAlgeria { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='AMERICAN SAMOA']")]
        protected IWebElement page1CountryAmericanSamoa { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ANDORRA']")]
        protected IWebElement page1CountryAndorra { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ANGOLA']")]
        protected IWebElement page1CountryAngola { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ANTARCTICA']")]
        protected IWebElement page1CountryAntarctica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ANTIGUA']")]
        protected IWebElement page1CountryAntigua { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ARGENTINA']")]
        protected IWebElement page1CountryArgentina { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ARMENIA']")]
        protected IWebElement page1CountryArmenia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ARUBA']")]
        protected IWebElement page1CountryAruba { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='AUSTRALIA']")]
        protected IWebElement page1CountryAustralia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='AUSTRIA']")]
        protected IWebElement page1CountryAustria { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='AZERBAIJAN']")]
        protected IWebElement page1CountryAzerbaijan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BAHAMAS']")]
        protected IWebElement page1CountryBahamas { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BAHRAIN']")]
        protected IWebElement page1CountryBahrain { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BANGLADESH']")]
        protected IWebElement page1CountryBangladesh { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BARBADOS']")]
        protected IWebElement page1CountryBarbados { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BELARUS']")]
        protected IWebElement page1CountryBelarus { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BELGIUM']")]
        protected IWebElement page1CountryBelgium { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BELIZE']")]
        protected IWebElement page1CountryBelize { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BENIN']")]
        protected IWebElement page1CountryBenin { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BERMUDA']")]
        protected IWebElement page1CountryBermuda { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BHUTAN']")]
        protected IWebElement page1CountryBhutan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BOLIVIA']")]
        protected IWebElement page1CountryBolivia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BOSNIA']")]
        protected IWebElement page1CountryBosnia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BOTSWANA']")]
        protected IWebElement page1CountryBotswana { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BOUVET ISLAND']")]
        protected IWebElement page1CountryBouvetIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BRAZIL']")]
        protected IWebElement page1CountryBrazil { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BRITISH ANTARCTICA TERRITORY']")]
        protected IWebElement page1CountryBritishAntarcticaTerritory { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BRITISH INDIAN OCEAN TERRITORY']")]
        protected IWebElement page1CountryBritishIndianOceanTerritory { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BRITISH VIRGIN ISLANDS']")]
        protected IWebElement page1CountryBritishVirginIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BRITISH WEST INDIES']")]
        protected IWebElement page1CountryBritishWestIndies { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BRUNEI']")]
        protected IWebElement page1CountryBrunei { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BULGARIA']")]
        protected IWebElement page1CountryBulgaria { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BURKINA FASO']")]
        protected IWebElement page1CountryBurkinaFaso { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='BURUNDI']")]
        protected IWebElement page1CountryBurundi { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CAMBODIA']")]
        protected IWebElement page1CountryCambodia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CAMEROON']")]
        protected IWebElement page1CountryCameroon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CANADA']")]
        protected IWebElement page1CountryCanada { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CANAL ZONE']")]
        protected IWebElement page1CountryCanalZone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CANARY ISLAND']")]
        protected IWebElement page1CountryCanaryIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CAPE VERDI ISLANDS']")]
        protected IWebElement page1CountryCapeVerdiIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CAYMAN ISLANDS']")]
        protected IWebElement page1CountryCaymanIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CEVLON']")]
        protected IWebElement page1CountryCevlon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CHAD']")]
        protected IWebElement page1CountryChad { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CHANNEL ISLAND UK']")]
        protected IWebElement page1CountryChannelIslandUk { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CHILE']")]
        protected IWebElement page1CountryChile { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CHINA']")]
        protected IWebElement page1CountryChina { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CHRISTMAS ISLAND']")]
        protected IWebElement page1CountryChristmasIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='COCOS (KEELING) ISLAND']")]
        protected IWebElement page1CountryCocosKeelingIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='COLOMBIA']")]
        protected IWebElement page1CountryColombia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='COMORO ISLANDS']")]
        protected IWebElement page1CountryComoroIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CONGO']")]
        protected IWebElement page1CountryCongo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CONGO KINSHASA']")]
        protected IWebElement page1CountryCongoKinshasa { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='COOK ISLANDS']")]
        protected IWebElement page1CountryCookIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='COSTA RICA']")]
        protected IWebElement page1CountryCostaRica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CROATIA']")]
        protected IWebElement page1CountryCroatia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CUBA']")]
        protected IWebElement page1CountryCuba { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CURACAO']")]
        protected IWebElement page1CountryCuracao { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CYPRUS']")]
        protected IWebElement page1CountryCyprus { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='CZECH REPUBLIC']")]
        protected IWebElement page1CountryCzechRepublic { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='DAHOMEY']")]
        protected IWebElement page1CountryDahomey { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='DENMARK']")]
        protected IWebElement page1CountryDenmark { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='DJIBOUTI']")]
        protected IWebElement page1CountryDjibouti { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='DOMINICA']")]
        protected IWebElement page1CountryDominica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='DOMINICAN REPUBLIC']")]
        protected IWebElement page1CountryDominicanRepublic { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='DUBAI']")]
        protected IWebElement page1CountryDubai { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ECUADOR']")]
        protected IWebElement page1CountryEcuador { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='EGYPT']")]
        protected IWebElement page1CountryEgypt { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='EL SALVADOR']")]
        protected IWebElement page1CountryElSalvador { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='EQUATORIAL GUINEA']")]
        protected IWebElement page1CountryEquatorialGuinea { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ESTONIA']")]
        protected IWebElement page1CountryEstonia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ETHIOPIA']")]
        protected IWebElement page1CountryEthiopia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FAEROE ISLANDS']")]
        protected IWebElement page1CountryFaeroeIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FALKLAND ISLANDS']")]
        protected IWebElement page1CountryFalklandIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FIJI']")]
        protected IWebElement page1CountryFiji { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FINLAND']")]
        protected IWebElement page1CountryFinland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FRENCH GUIANA']")]
        protected IWebElement page1CountryFrenchGuiana { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='FRENCH POLYNESIA']")]
        protected IWebElement page1CountryFrenchPolynesia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GABON']")]
        protected IWebElement page1CountryGabon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GAMBIA']")]
        protected IWebElement page1CountryGambia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GEORGIA']")]
        protected IWebElement page1CountryGeorgia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GHANA']")]
        protected IWebElement page1CountryGhana { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GIBRALTAR']")]
        protected IWebElement page1CountryGibraltar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GREECE']")]
        protected IWebElement page1CountryGreece { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GREENLAND']")]
        protected IWebElement page1CountryGreenland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GUADELOUPE']")]
        protected IWebElement page1CountryGuadeloupe { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GUAM']")]
        protected IWebElement page1CountryGuam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GUATEMALA']")]
        protected IWebElement page1CountryGuatemala { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GUINEA']")]
        protected IWebElement page1CountryGuinea { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='GUYANA']")]
        protected IWebElement page1CountryGuyana { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='HAITI']")]
        protected IWebElement page1CountryHaiti { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='HONDURAS']")]
        protected IWebElement page1CountryHonduras { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='HONG KONG']")]
        protected IWebElement page1CountryHongKong { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='HUNGARY']")]
        protected IWebElement page1CountryHungary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ICELAND']")]
        protected IWebElement page1CountryIceland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='IFNI']")]
        protected IWebElement page1CountryIfni { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='INDIA']")]
        protected IWebElement page1CountryIndia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='INDONESIA']")]
        protected IWebElement page1CountryIndonesia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='IRAN']")]
        protected IWebElement page1CountryIran { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='IRAQ']")]
        protected IWebElement page1CountryIraq { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='IRELAND']")]
        protected IWebElement page1CountryIreland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ISRAEL']")]
        protected IWebElement page1CountryIsrael { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='IVORY COAST']")]
        protected IWebElement page1CountryIvoryCoast { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='JAMAICA']")]
        protected IWebElement page1CountryJamaica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='JAPAN']")]
        protected IWebElement page1CountryJapan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='JORDAN']")]
        protected IWebElement page1CountryJordan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='KAZAKHSTAN']")]
        protected IWebElement page1CountryKazakhstan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='KENYA']")]
        protected IWebElement page1CountryKenya { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='KOREA']")]
        protected IWebElement page1CountryKorea { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='KOREA, SOUTH']")]
        protected IWebElement page1CountryKoreaSouth { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='KUWAIT']")]
        protected IWebElement page1CountryKuwait { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='KYRGYZSTAN']")]
        protected IWebElement page1CountryKyrgyzstan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LAOS']")]
        protected IWebElement page1CountryLaos { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LATVIA']")]
        protected IWebElement page1CountryLatvia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LEBANON']")]
        protected IWebElement page1CountryLebanon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LEEWARD ISLANDS']")]
        protected IWebElement page1CountryLeewardIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LESOTHO']")]
        protected IWebElement page1CountryLesotho { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LIBYA']")]
        protected IWebElement page1CountryLibya { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LIECHTENSTEIN']")]
        protected IWebElement page1CountryLiechtenstein { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LITHUANIA']")]
        protected IWebElement page1CountryLithuania { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='LUXEMBOURG']")]
        protected IWebElement page1CountryLuxembourg { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MACAO']")]
        protected IWebElement page1CountryMacao { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MACEDONIA']")]
        protected IWebElement page1CountryMacedonia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MADAGASCAR']")]
        protected IWebElement page1CountryMadagascar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MALAWI']")]
        protected IWebElement page1CountryMalawi { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MALAYSIA']")]
        protected IWebElement page1CountryMalaysia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MALDIVES']")]
        protected IWebElement page1CountryMaldives { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MALI']")]
        protected IWebElement page1CountryMali { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MALTA']")]
        protected IWebElement page1CountryMalta { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MARTINIQUE']")]
        protected IWebElement page1CountryMartinique { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MAURITANIA']")]
        protected IWebElement page1CountryMauritania { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MAURITIUS']")]
        protected IWebElement page1CountryMauritius { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MELANESIA']")]
        protected IWebElement page1CountryMelanesia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MEXICO']")]
        protected IWebElement page1CountryMexico { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MOLDOVIA']")]
        protected IWebElement page1CountryMoldovia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MONACO']")]
        protected IWebElement page1CountryMonaco { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MONGOLIA']")]
        protected IWebElement page1CountryMongolia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MOROCCO']")]
        protected IWebElement page1CountryMorocco { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MOZAMBIQUE']")]
        protected IWebElement page1CountryMozambique { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='MYANAMAR']")]
        protected IWebElement page1CountryMyanamar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NAMIBIA']")]
        protected IWebElement page1CountryNamibia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NEPAL']")]
        protected IWebElement page1CountryNepal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NETHERLANDS']")]
        protected IWebElement page1CountryNetherlands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NETHERLANDS ANTILLES']")]
        protected IWebElement page1CountryNetherlandsAntilles { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NETHERLANDS ANTILLES NEUTRAL ZONE']")]
        protected IWebElement page1CountryNetherlandsAntillesNeutralZone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NEW CALADONIA']")]
        protected IWebElement page1CountryNewCaladonia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NEW HEBRIDES']")]
        protected IWebElement page1CountryNewHebrides { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NEW ZEALAND']")]
        protected IWebElement page1CountryNewZealand { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NICARAGUA']")]
        protected IWebElement page1CountryNicaragua { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NIGER']")]
        protected IWebElement page1CountryNiger { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NIGERIA']")]
        protected IWebElement page1CountryNigeria { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NORFOLK ISLAND']")]
        protected IWebElement page1CountryNorfolkIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='NORWAY']")]
        protected IWebElement page1CountryNorway { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='OMAN']")]
        protected IWebElement page1CountryOman { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='OTHER']")]
        protected IWebElement page1CountryOther { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PACIFIC ISLAND']")]
        protected IWebElement page1CountryPacificIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PAKISTAN']")]
        protected IWebElement page1CountryPakistan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PANAMA']")]
        protected IWebElement page1CountryPanama { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PAPUA NEW GUINEA']")]
        protected IWebElement page1CountryPapuaNewGuinea { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PARAGUAY']")]
        protected IWebElement page1CountryParaguay { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PERU']")]
        protected IWebElement page1CountryPeru { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PHILIPPINES']")]
        protected IWebElement page1CountryPhilippines { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='POLAND']")]
        protected IWebElement page1CountryPoland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PORTUGAL']")]
        protected IWebElement page1CountryPortugal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PORTUGUESE TIMOR']")]
        protected IWebElement page1CountryPortugueseTimor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='PUERTO RICO']")]
        protected IWebElement page1CountryPuertoRico { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='QATAR']")]
        protected IWebElement page1CountryQatar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='REPUBLIC OF BELARUS']")]
        protected IWebElement page1CountryRepublicOfBelarus { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='REPUBLIC OF SOUTH AFRICA']")]
        protected IWebElement page1CountryRepublicOfSouthAfrica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='REUNION']")]
        protected IWebElement page1CountryReunion { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ROMANIA']")]
        protected IWebElement page1CountryRomania { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='RUSSIA']")]
        protected IWebElement page1CountryRussia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='RWANDA']")]
        protected IWebElement page1CountryRwanda { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='RYUKYU ISLANDS']")]
        protected IWebElement page1CountryRyukyuIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SABAH']")]
        protected IWebElement page1CountrySabah { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SAN MARINO']")]
        protected IWebElement page1CountrySanMarino { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SAUDI ARABIA']")]
        protected IWebElement page1CountrySaudiArabia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SENEGAL']")]
        protected IWebElement page1CountrySenegal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SERBIA']")]
        protected IWebElement page1CountrySerbia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SEYCHELLES']")]
        protected IWebElement page1CountrySeychelles { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SIERRA LEONE']")]
        protected IWebElement page1CountrySierraLeone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SINGAPORE']")]
        protected IWebElement page1CountrySingapore { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SLOVAKIA']")]
        protected IWebElement page1CountrySlovakia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SLOVENIA']")]
        protected IWebElement page1CountrySlovenia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SOMALILIAND']")]
        protected IWebElement page1CountrySomaliliand { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SOUTH AFRICA']")]
        protected IWebElement page1CountrySouthAfrica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SOUTH YEMEN']")]
        protected IWebElement page1CountrySouthYemen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SPANISH SAHARA']")]
        protected IWebElement page1CountrySpanishSahara { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SRI LANKA']")]
        protected IWebElement page1CountrySriLanka { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ST. KITTS AND NEVIS']")]
        protected IWebElement page1CountryStKittsAndNevis { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ST. LUCIA']")]
        protected IWebElement page1CountryStLucia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SUDAN']")]
        protected IWebElement page1CountrySudan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SURINAM']")]
        protected IWebElement page1CountrySurinam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SW AFRICA']")]
        protected IWebElement page1CountrySwAfrica { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SWAZILAND']")]
        protected IWebElement page1CountrySwaziland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SWEDEN']")]
        protected IWebElement page1CountrySweden { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SWITZERLAND']")]
        protected IWebElement page1CountrySwitzerland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='SYRIA']")]
        protected IWebElement page1CountrySyria { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TAIWAN']")]
        protected IWebElement page1CountryTaiwan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TAJIKISTAN']")]
        protected IWebElement page1CountryTajikistan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TANZANIA']")]
        protected IWebElement page1CountryTanzania { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='THAILAND']")]
        protected IWebElement page1CountryThailand { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TONGA']")]
        protected IWebElement page1CountryTonga { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TRINIDAD']")]
        protected IWebElement page1CountryTrinidad { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TUNISIA']")]
        protected IWebElement page1CountryTunisia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='TURKEY']")]
        protected IWebElement page1CountryTurkey { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='UGANDA']")]
        protected IWebElement page1CountryUganda { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='UKRAINE']")]
        protected IWebElement page1CountryUkraine { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='UNITED ARAB EMIRATES']")]
        protected IWebElement page1CountryUnitedArabEmirates { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='UPPER VOLTA']")]
        protected IWebElement page1CountryUpperVolta { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='URUGUAY']")]
        protected IWebElement page1CountryUruguay { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='US PACIFIC ISLAND']")]
        protected IWebElement page1CountryUsPacificIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='US VIRGIN ISLANDS']")]
        protected IWebElement page1CountryUsVirginIslands { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='USA']")]
        protected IWebElement page1CountryUsa { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='UZBEKISTAN']")]
        protected IWebElement page1CountryUzbekistan { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='VANUATU']")]
        protected IWebElement page1CountryVanuatu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='VATICAN CITY']")]
        protected IWebElement page1CountryVaticanCity { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='VENEZUELA']")]
        protected IWebElement page1CountryVenezuela { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='VIETNAM']")]
        protected IWebElement page1CountryVietnam { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='WAKE ISLAND']")]
        protected IWebElement page1CountryWakeIsland { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='WEST INDIES']")]
        protected IWebElement page1CountryWestIndies { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='WESTERN SAHARA']")]
        protected IWebElement page1CountryWesternSahara { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='YEMEN']")]
        protected IWebElement page1CountryYemen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ZAIRE']")]
        protected IWebElement page1CountryZaire { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ZAMBIA']")]
        protected IWebElement page1CountryZambia { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='addrcountry_c_chosen']/div/ul/li[text()='ZIMBABWE']")]
        protected IWebElement page1CountryZimbabwe { get; set; }

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

        #region Page-2 Elements

        [FindsBy(How = How.XPath, Using = ".//*[@id='english_language']")]
        protected IWebElement page2LanguageEnglish { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='form-step2']/div[17]/div/div/input[2]")]
        protected IWebElement page2ApplyNow { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='form-step2']/div[18]/div/div/input[2]")]
        protected IWebElement page2ApplyNowAdditional { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='auto_detect_language']")]
        [FindsBy(How = How.Id, Using = "auto_detect_language")]
        protected IWebElement page2LanguageAutoDetection { get; set; }

        #endregion

        #region Page-3 Elements
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/section/article/div/div/header/h1")]
        protected IWebElement page3ThankyouForYourApplication { get; set; }
        #endregion

        #region Main Procedure
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
            throw new NotImplementedException();
        }

        public bool ApplicantMandatoryFill()
        {
            if (ApplicationPage1())
            {
                page1BottomNext.Click();
                if (ApplicationPage2())
                {
                    try
                    {
                        page2ApplyNow.Click();
                    }
                    catch (Exception)
                    {
                        page2ApplyNowAdditional.Click();
                    }

                    return NewApplicationInfoPage3();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Sub Process
        public bool ApplicationPage1()
        {
            try
            {
                Countries ct = new Countries();

                page1NoThanks.Click();
                page1Title.SendKeys(Titles.Dr);
                page1FirstName.EnterText(string.Format("{0}", JobName));
                page1LastName.EnterText(string.Format("{0}", JobName));
                page1AddressLine1.EnterText("Airport Business Park Building C 92/1 Mahidol Road");
                page1AddressLine2.EnterText("Tambon Haiya Amphur Muang");
                page1ZipCode.EnterText("50100");
                page1City.EnterText("Chiang Mai");

                page1Country.Click();
                PropertiesCollection.Sleep500();
                page1CountryAlbania.Click();
                PropertiesCollection.Sleep500();
                page1Email.EnterText(Emails.HrmTest);
                page1Telephone.EnterText("053-904748");
                page1Mobile.EnterText("081-2568894");

                page1DateOfBirth.EnterText("1995.08.28");
                page1DateOfBirth.SendKeys(Keys.Tab);
                PropertiesCollection.Sleep500();

                page1Nationality.Click();
                PropertiesCollection.Sleep500();
                page1NationalityThai.Click();
                //PropertiesCollection.Sleep500();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ApplicationPage2()
        {
            try
            {
                if (IsAutoLanguageDetection)
                {
                    while (!IsReadyAutoLanguageDetection) ;

                    page2LanguageEnglish.SendKeys(LanguageSkill.MotherTongue);
                    page2LanguageAutoDetection.SendKeys(LanguageSkill.Fluent);
                }
                else
                {
                    while (!ReadyPage2()) ;

                    page2LanguageEnglish.SendKeys(LanguageSkill.MotherTongue);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool NewApplicationInfoPage3()
        {
            while (!ReadyPage3()) ;
            return true;
        }

        #endregion

        #region Ready Page
        private bool IsAutoLanguageDetection
        {
            get
            {
                if (JobAlias.Equals("Sales_Agent_En") || JobAlias.Equals("CC_Agent_En"))
                {
                    return false;
                }
                else if (JobAlias.Contains("Sales_Agent") || JobAlias.Contains("CC_Agent"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool IsReadyAutoLanguageDetection
        {
            get
            {
                try
                {
                    return page2LanguageAutoDetection.Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private bool ReadyPage2()
        {
            try
            {
                return page2ApplyNow.Displayed;
            }
            catch (Exception)
            {
                try
                {
                    return page2ApplyNowAdditional.Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private bool ReadyPage3()
        {
            try
            {
                return page3ThankyouForYourApplication.IsInnerHtml("Thank you");
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

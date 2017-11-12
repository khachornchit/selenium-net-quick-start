using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using SeleniumUtilities.Definition;
using System;
using System.Collections.Generic;

namespace SeleniumUtilities
{
    public class PropertiesCollection
    {
        public static string TesterName { get { return "CLBS QA Tester"; } }

        public static string TesterEmailClbs { get { return "kajornjit.songsaen@clbs.co.th"; } }

        public static string TesterEmailGmail { get { return "clbsqatester@gmail.com"; } }

        public static string TesterPhone { get { return "66 53 904 748"; } }

        public static IWebDriver driver { get; set; }

        public static TimeSpan timeSpan { get; set; }

        public static LanguageLevel LanguageLevel;

        public static string ParentWindowHandle { get; set; }

        public static bool SwitchToPopUpWindowsHandle(string PopUpWindowsText)
        {
            try
            {
                ParentWindowHandle = driver.CurrentWindowHandle;
                IWebDriver popup = null;
                var windowIterator = PropertiesCollection.driver.WindowHandles;

                foreach (var windowHandle in windowIterator)
                {
                    popup = PropertiesCollection.driver.SwitchTo().Window(windowHandle);

                    if (popup.Title.ToLower().Contains(PopUpWindowsText.ToLower()))
                    {
                        PopUpWindowHandle = windowHandle;
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SwitchToParentWindowsHandle()
        {
            try
            {
                PropertiesCollection.driver.SwitchTo().Window(ParentWindowHandle);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<string> ListPopUpWindowsHandle()
        {
            List<string> pWindows = new List<string>();

            try
            {
                ParentWindowHandle = driver.CurrentWindowHandle;
                IWebDriver popup = null;
                var windowIterator = PropertiesCollection.driver.WindowHandles;

                int i = 1;
                foreach (var windowHandle in windowIterator)
                {
                    //popup = PropertiesCollection.driver.SwitchTo().Window(windowHandle);

                    ////if (popup.Title.ToLower().Contains(PopUpWindowsText.ToLower()))
                    ////{
                    ////    PopUpWindowHandle = windowHandle;
                    ////    return true;
                    ////}

                    //Console.WriteLine("Popup Title {0}: {1}", i++, popup.Title);

                    pWindows.Add(popup.Title);
                }

                //Console.WriteLine("Finish list out of popup windows.");
                pWindows.Add("Finish");
            }
            catch (Exception)
            {
                //Console.WriteLine("Found error during switch to popui windows.");
                pWindows.Add("Found error during switch to popui windows.");
            }

            return pWindows;
        }

        public static string PopUpWindowHandle { get; set; }

        public static string FacebookWindowHandle { get; set; }

        public static string InitializeUrl { get; set; }

        //public static void SetDefaultBrowserPhantom()
        //{
        //    PropertiesCollection.driver = new PhantomJSDriver();
        //}

        public static void SetDefaultBrowserChrome()
        {
            PropertiesCollection.driver = new ChromeDriver();
        }

        public static void OpenBrowser(string Url)
        {
            //PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.timeSpan = TimeSpan.FromSeconds(5);
            PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(PropertiesCollection.timeSpan);
            PropertiesCollection.driver.Navigate().GoToUrl(Url);
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

        public static void OpenBrowserChrome(string Url)
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.timeSpan = TimeSpan.FromSeconds(5);
            PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(PropertiesCollection.timeSpan);
            PropertiesCollection.driver.Navigate().GoToUrl(Url);
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

        //public static void OpenBrowserPhantom(string Url)
        //{
        //    PropertiesCollection.driver = new PhantomJSDriver();
        //    PropertiesCollection.timeSpan = TimeSpan.FromSeconds(5);
        //    PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(PropertiesCollection.timeSpan);
        //    PropertiesCollection.driver.Navigate().GoToUrl(Url);
        //    PropertiesCollection.driver.Manage().Window.Maximize();
        //}

        //public static void OpenBrowserFirefox(string URL)
        //{
        //    PropertiesCollection.driver = new FirefoxDriver();
        //    PropertiesCollection.timeSpan = TimeSpan.FromSeconds(20);
        //    PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(PropertiesCollection.timeSpan);
        //    PropertiesCollection.driver.Navigate().GoToUrl(URL);
        //    PropertiesCollection.driver.Manage().Window.Maximize();
        //}

        public static void SwitchToFrame(string FrameName)
        {
            driver.SwitchTo().Frame(FrameName);
        }

        public static void Navigate(string URL)
        {
            PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(PropertiesCollection.timeSpan);
            PropertiesCollection.driver.Navigate().GoToUrl(URL);
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

        public static void Sleep100()
        {
            System.Threading.Thread.Sleep(100);
        }

        public static void Sleep200()
        {
            System.Threading.Thread.Sleep(200);
        }

        public static void Sleep300()
        {
            System.Threading.Thread.Sleep(300);
        }

        public static void Sleep400()
        {
            System.Threading.Thread.Sleep(400);
        }

        public static void Sleep500()
        {
            System.Threading.Thread.Sleep(500);
        }

        public static void Sleep1000()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public static void Sleep2000()
        {
            System.Threading.Thread.Sleep(2000);
        }

        public static void Sleep3000()
        {
            System.Threading.Thread.Sleep(3000);
        }

        public static void Sleep4000()
        {
            System.Threading.Thread.Sleep(4000);
        }

        public static void Sleep5000()
        {
            System.Threading.Thread.Sleep(5000);
        }

        public static string GetTodayString { get { return string.Format("{0:00}/{1:00}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year); } }

        public static string GetTomorrowString { get { return string.Format("{0:00}/{1:00}/{2}", DateTime.Now.AddDays(1).Day, DateTime.Now.AddDays(1).Month, DateTime.Now.AddDays(1).Year); } }

        public static string GetTodayStringDotSeparate { get { return string.Format("{0:00}.{1:00}.{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year); } }

        public static string GetTomorrowStringDotSeparate { get { return string.Format("{0:00}.{1:00}.{2}", DateTime.Now.AddDays(1).Day, DateTime.Now.AddDays(1).Month, DateTime.Now.AddDays(1).Year); } }

        public static object TestCode { get { return "000TEST000"; } }
    }
}

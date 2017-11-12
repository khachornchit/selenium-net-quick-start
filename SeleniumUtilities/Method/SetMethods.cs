using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SeleniumUtilities
{
    public static class SeleniumSetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        
        public static void Clicks(this IWebElement element)
        {
            //element.Click();
            element.Submit();
        }
        
        public static void SelectDropDownByName(this IWebElement element, string value)
        {
            //Select by Option Name
            new SelectElement(element).SelectByText(value);
        }

        public static void SelectDropDownByValue(this IWebElement element, string value)
        {
            //Select by option value
            new SelectElement(element).SelectByValue(value);
        }

        public static void SelectDropDownValueClbs(this IWebElement element, string value)
        {
            IList<IWebElement> options = element.FindElements(By.TagName("option"));

            foreach (IWebElement option in options)
            {
                if (option.GetText().Equals(value))
                {
                    option.Click();
                    break;
                }
            }
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SeleniumUtilities
{
    public static class SeleniumGetMethods
    {
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static string GetInnerHtml(this IWebElement element)
        {
            return element.GetAttribute("innerHTML");
        }

        public static bool IsInnerHtml(this IWebElement element, string value)
        {
            return element.GetAttribute("innerHTML").ToLower().Contains(value.ToLower().Trim());
        }
    }
}
using Selenium2016.Models;
using System.Collections.Generic;

namespace Selenium2016.Process
{
    public class FundamentalFields
    {
        public string Name { get; set; }
        public List<TestResultInPage> TestResultInPages { get; set; }
        private string TestName { get; set; }
        public static string Url { get; set; }
    } 
}
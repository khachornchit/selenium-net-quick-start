using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUtilities.Tests
{
    [TestClass]
    public class TestPropertiesCollection
    {
        [TestMethod]
        public void TestToday()
        {
            Console.WriteLine(string.Format("Today : {0}", PropertiesCollection.GetTodayString));
        }

        [TestMethod]
        public void TestTomorrow()
        {
            Console.WriteLine(string.Format("Today : {0}", PropertiesCollection.GetTomorrowString));
        }

        [TestMethod]
        public void TestTodayDotSeparate()
        {
            Console.WriteLine(string.Format("Today : {0}", PropertiesCollection.GetTodayStringDotSeparate));
        }

        [TestMethod]
        public void TestTomorrowDotSeparate()
        {
            Console.WriteLine(string.Format("Today : {0}", PropertiesCollection.GetTomorrowStringDotSeparate));
        }
    }
}

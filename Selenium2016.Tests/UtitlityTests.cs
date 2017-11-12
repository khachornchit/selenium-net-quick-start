using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium2016.Models;

namespace Selenium2016.Tests
{
    [TestClass]
    public class UtitlityTests
    {
        [TestMethod]
        public void AutoIdTest()
        {
            Console.WriteLine(AutoId.Id);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint2.Task4.V12.Lib;

namespace Tyuiu.VoroshilovNA.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService dataService = new DataService();
            double x = 5, y = 1, res = dataService.Calculate(x, y), wait = 59049;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService dataService = new DataService();
            double x = 3, y = 4, res = dataService.Calculate(x, y), wait = 1.326;
            Assert.AreEqual(wait, res);
        }
    }
}

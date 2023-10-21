using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.VoroshilovNA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int value = 3;
            string res = "Среда";
            Assert.AreEqual(res, ds.FindDayName(value));
        }
    }
}

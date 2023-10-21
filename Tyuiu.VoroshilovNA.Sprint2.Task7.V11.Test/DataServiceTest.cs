﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint2.Task7.V11.Lib;

namespace Tyuiu.VoroshilovNA.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.8;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}

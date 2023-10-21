﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint2.Review.V15.Lib;

namespace Tyuiu.ModenovaAP.Sprint2.Review.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 2;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}
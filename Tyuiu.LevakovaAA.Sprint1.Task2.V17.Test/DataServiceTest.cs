﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint1.Task2.V17.Lib;
namespace Tyuiu.LevakovaAA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 90;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(1, res);

        }
    }
}

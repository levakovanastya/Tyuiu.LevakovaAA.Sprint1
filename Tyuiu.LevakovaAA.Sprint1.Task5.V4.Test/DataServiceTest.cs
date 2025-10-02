using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.LevakovaAA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 3601;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(time);
            int result = Convert.ToInt32(res);
            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}

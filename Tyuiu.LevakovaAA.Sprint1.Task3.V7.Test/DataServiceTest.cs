using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint1.Task3.V7.Lib;
namespace Tyuiu.LevakovaAA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(106.68, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint1.Task1.V2.Lib;
namespace Tyuiu.LevakovaAA.Sprint1.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.75, res);
        }
    }
}

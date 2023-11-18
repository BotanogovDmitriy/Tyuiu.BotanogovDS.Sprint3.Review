using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint3.TaskReview.V7.Lib;

namespace Tyuiu.BotanogovDS.Sprint3.TaskReview.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(stopValue - startValue + 1, result.Length);
        }
    }
}

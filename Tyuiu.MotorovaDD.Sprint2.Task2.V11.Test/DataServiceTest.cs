using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint2.Task2.V11.Lib;

namespace Tyuiu.MotorovaDD.Sprint2.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 12;
            int y = 11;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}

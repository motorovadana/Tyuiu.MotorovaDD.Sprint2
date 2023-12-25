using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint2.Task3.V18.Lib;

namespace Tyuiu.MotorovaDD.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            
            {
                DataService ds = new DataService();
                double x = 0;
                double res = ds.Calculate(x);
                double wait = 0.75;
                Assert.AreEqual(wait, res);
            }
            {
                DataService ds = new DataService();
                double x = 1;
                double res = ds.Calculate(x);
                double wait = 2;
                Assert.AreEqual(wait, res);
            }

           
            {
                DataService ds = new DataService();
                double x = -100;
                double res = ds.Calculate(x);
                double wait = -1099.99;
                Assert.AreEqual(wait, res);
            }
        }
    }
}

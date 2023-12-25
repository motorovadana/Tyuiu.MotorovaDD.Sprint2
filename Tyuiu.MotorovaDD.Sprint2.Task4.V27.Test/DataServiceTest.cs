using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint2.Task4.V27.Lib;
namespace Tyuiu.MotorovaDD.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
                DataService ds = new DataService();
                double x = 2;
                double y = 2;
                double res = ds.Calculate(x, y);
                double wait = 3;
                Assert.AreEqual(wait, res);
            }

            {
                DataService ds = new DataService();
                double x = 2;
                double y = 2;
                double res = ds.Calculate(x, y);
                double wait = 3;

                Assert.AreEqual(wait, res);

            }
        }
    }
}        

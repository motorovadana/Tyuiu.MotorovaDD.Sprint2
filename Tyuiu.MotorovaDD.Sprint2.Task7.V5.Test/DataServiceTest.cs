﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint2.Task7.V5.Lib;

namespace Tyuiu.MotorovaDD.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
    
            public void ValidCheckDotInShadedArea()
            {
                DataService ds = new DataService();

                double x = 0.5;
                double y = 0.5;

                bool res = ds.CheckDotInShadedArea(x, y);

                bool wait = false;

                Assert.AreEqual(wait, res);


            }
    }
}

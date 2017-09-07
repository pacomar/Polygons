using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPolygons
{
    [TestClass]
    public class TestPoint
    {
        [TestMethod]
        public void TestPointX()
        {
            Point point = new Point(0, 1);
            int expectedResult = 0;
            int actualResult = point.GetX();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPointY()
        {
            Point point = new Point(0, 1);
            int expectedResult = 1;
            int actualResult = point.GetY();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

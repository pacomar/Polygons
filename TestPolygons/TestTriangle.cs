using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polygons;

namespace TestPolygons
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestArea()
        {
            Triangle triangle = new Triangle(new Point(1, 1), new Point(2,2), new Point(1, 3));
            double expectedResult = 1;
            double actualResult = triangle.GetArea();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

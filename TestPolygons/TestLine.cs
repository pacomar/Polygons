
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polygons;

namespace TestPolygons
{
    [TestClass]
    public class TestLine
    {
        [TestMethod]
        public void TestLength()
        {
            Line line = new Line(new Point(0, 0), new Point(0, 3));
            int expectedResult = 3;
            int actualResult = line.GetLength();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

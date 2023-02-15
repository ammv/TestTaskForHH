using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shapes;

namespace TestShapes
{
    [TestClass]
    public class TestTriangles
    {
        [TestMethod]
        public void Creating_NotExists_Trinagular_Throw()
        {
            // Arrange
            var (a, b, c) = (3d, 1d, 2d);
            // Act and assert
            Assert.ThrowsException<TriangleException>(() => new Triangle(a, b, c));
        }

        [TestMethod]
        public void Rectangular_Triangle_IsRectangular()
        {
            // Arrange
            var rectangularTrinagle = new Triangle(4, 3, 5);

            // Act
            bool isRectangular = rectangularTrinagle.IsRectangular();

            // Assert
            Assert.IsTrue(isRectangular);
        }

        [TestMethod]
        public void NotRectangular_Triangle_IsNotRectangular()
        {
            // Arrange
            var rectangularTrinagle = new Triangle(4, 3, 4);

            // Act
            bool isRectangular = rectangularTrinagle.IsRectangular();

            // Assert
            Assert.IsFalse(isRectangular);
        }

        [TestMethod]
        public void Triangular_Area_Calculated_True()
        {
            // Arrange
            var (a, b, c) = (4d, 2d, 3d);

            var p = (a + b + c) / 2;
            var exceptedArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            var triangle = new Triangle(a, b, c);

            // Act
            double area = triangle.Area;

            // Assert
            Assert.AreEqual(exceptedArea, area);
        }
    }
}
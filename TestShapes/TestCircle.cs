using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestShapes
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void Creating_NotExists_Circle_Throw()
        {
            // Arrange
            double radius = 0;

            // Act and assert
            Assert.ThrowsException<Shapes.CircleException>(() => new Shapes.Circle(radius));
        }

        [TestMethod]
        public void Circle_Area_Calculated_True()
        {
            // Arrange
            double r1 = 145;
            double expectedArea = Math.PI * r1 * r1;
            var circle = new Shapes.Circle(r1);

            // Act
            double area = circle.Area;

            // Assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestShapes
{
    [TestClass]
    public class TestCircle
    {
        /// <summary>
        /// Checks creation of circles with correct and incorrect radius
        /// </summary>
        [TestMethod]
        public void TestCircleCreation()
        {
            var circle = new Shapes.Circle(5);
            Assert.AreEqual(circle.Radius, 5);
            Assert.ThrowsException<Shapes.CircleException>(() => new Shapes.Circle(0));
            Assert.ThrowsException<Shapes.CircleException>(() => new Shapes.Circle(-1));
        }

        /// <summary>
        /// Checks the calculation of the area of the circle
        /// </summary>
        [TestMethod]
        public void TestCalculatingArea()
        {
            double r1 = 145, r2 = 1.12345;
            var circle = new Shapes.Circle(r1);
            var circle2 = new Shapes.Circle(r2);

            Assert.AreEqual(circle.GetArea(), Math.PI * r1 * r1);
            Assert.AreEqual(circle2.GetArea(), Math.PI * r2 * r2);
        }
    }
}
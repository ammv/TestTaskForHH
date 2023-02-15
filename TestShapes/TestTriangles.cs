using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestShapes
{
    [TestClass]
    public class TestTriangles
    {
        /// <summary>
        /// Checks the creation of triangles with right sides and wrong sides
        /// </summary>
        [TestMethod]
        public void TestTriangleCreation()
        {
            var circle = new Shapes.Triangle(4, 2, 3);

            Assert.AreEqual(circle.SideA, 4);
            Assert.AreEqual(circle.SideB, 2);
            Assert.AreEqual(circle.SideC, 3);

            Assert.ThrowsException<Shapes.TriangleException>(() => new Shapes.Triangle(3, 1, 2));
            Assert.ThrowsException<Shapes.TriangleException>(() => new Shapes.Triangle(2, 3, 5));
            Assert.ThrowsException<Shapes.TriangleException>(() => new Shapes.Triangle(1, 3, 7));
            Assert.ThrowsException<Shapes.TriangleException>(() => new Shapes.Triangle(0, 2, 3));
        }

        /// <summary>
        /// Checks the correctness of the definition of right-angled triangles
        /// </summary>
        [TestMethod]
        public void TestTriangleIsRectangular()
        {
            var rectangularTrinagle = new Shapes.Triangle(4, 3, 5);
            var notRectangularTrinagle = new Shapes.Triangle(4, 2, 3);

            Assert.AreEqual(rectangularTrinagle.IsRectangular(), true);
            Assert.AreEqual(notRectangularTrinagle.IsRectangular(), false);
        }

        /// <summary>
        /// Checks the calculation of the area of the triangle
        /// </summary>
        [TestMethod]
        public void TestCalculatingArea()
        {
            var (a, b, c) = (4d, 2d, 3d);
            var (a2, b2, c2) = (4d, 2d, 5d);

            var p = (a + b + c) / 2;
            var p2 = (a2 + b2 + c2) / 2;

            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            var s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

            var triangle = new Shapes.Triangle(a, b, c);
            var triangle2 = new Shapes.Triangle(a2, b2, c2);

            Assert.AreEqual(triangle.GetArea(), s);
            Assert.AreEqual(triangle2.GetArea(), s2);
        }
    }
}
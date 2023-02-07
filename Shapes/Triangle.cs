using System;

namespace Shapes
{
    /// <summary>
    /// Class for exceptions related to the <see cref="Triangle"/> class
    /// </summary>
    public class TriangleException : Exception
    {
        /// <summary>
        /// Initializes the new instance of the <see cref="TriangleException"/> with a specified error message
        /// </summary>
        /// <param name="message">Error message</param>
        public TriangleException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// Represents a class for creating triangles
    /// </summary>
    public class Triangle : Base.Shape
    {
        private double c;
        private double a;
        private double b;

        /// <summary>
        /// First side
        /// </summary>
        public double A { get => a; set => a = value; }

        /// <summary>
        /// Second side
        /// </summary>
        public double B { get => b; set => b = value; }

        /// <summary>
        /// Third side
        /// </summary>
        public double C { get => c; set => c = value; }

        /// <summary>
        /// Creates a triangle on three sides
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <exception cref="TriangleException">If the sides do not form a triangle</exception>
        public Triangle(double a, double b, double c)
        {
            if (!IsExists(a, b, c))
            {
                throw new TriangleException("A triangle with such sides does not exist");
            }
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Checks whether the triangle is rectangular according to the Pythagorean formula: c^2 = a^2 + b^2
        /// </summary>
        /// <returns>
        /// <para><see langword="true"/> - the triangle is rectangular</para>
        /// <para><see langword="false"/> - the triangle is not rectangular</para>
        /// </returns>
        public bool IsRectangular()
        {
            return c * c == a * a + b * b;
        }

        /// <summary>
        /// <para>Checks the existence of a triangle on three sides according to the following conditions:</para>
        /// <para>a &lt; b + c</para>
        /// <para>b &lt; a + c</para>
        /// <para>c &lt; a + b</para>
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <returns>
        /// <para><see langword="true"/> - a triangle with such sides exists</para>
        /// <para><see langword="false"/> - a triangle with such sides does not exist</para>
        /// </returns>
        public static bool IsExists(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0) &&
                (a < b + c) && (b < a + c) && (c < a + b);
        }

        /// <summary>
        /// Calculates the area of a triangle using Heron 's formula: sqrt(p(p - a)(p - b)(p - c))
        /// </summary>
        /// <returns>
        /// The area of the triangle
        /// </returns>
        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
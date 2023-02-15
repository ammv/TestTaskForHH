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
        /// <summary>
        /// First side
        /// </summary>
        public double SideA { get; private set; }

        /// <summary>
        /// Second side
        /// </summary>
        public double SideB { get; private set; }

        /// <summary>
        /// Third side
        /// </summary>
        public double SideC { get; private set; }

        /// <summary>
        /// Creates a triangle on three sides
        /// </summary>
        /// <param name="sideA">First side</param>
        /// <param name="sideB">Second side</param>
        /// <param name="sideC">Third side</param>
        /// <exception cref="TriangleException">If the sides do not form a triangle</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsExists(sideA, sideB, sideC))
            {
                throw new TriangleException("A triangle with such sides does not exist");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            double p = (SideA + SideB + SideC) / 2;
            Area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
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
            return SideC * SideC == SideA * SideA + SideB * SideB;
        }

        /// <summary>
        /// <para>Checks the existence of a triangle on three sides according to the following conditions:</para>
        /// <para>a > 0 and b > 0 and c > 0</para>
        /// <para>a &lt; b + c</para>
        /// <para>b &lt; a + c</para>
        /// <para>c &lt; a + b</para>
        /// </summary>
        /// <param name="sideA">First side</param>
        /// <param name="sideB">Second side</param>
        /// <param name="sideC">Third side</param>
        /// <returns>
        /// <para><see langword="true"/> - a triangle with such sides exists</para>
        /// <para><see langword="false"/> - a triangle with such sides does not exist</para>
        /// </returns>
        public static bool IsExists(double sideA, double sideB, double sideC)
        {
            return (sideA > 0 && sideB > 0 && sideC > 0) &&
                (sideA < sideB + sideC) &&
                (sideB < sideA + sideC) &&
                (sideC < sideA + sideB);
        }
    }
}
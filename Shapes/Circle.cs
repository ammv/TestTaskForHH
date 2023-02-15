using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    /// <summary>
    /// Class for exceptions related to the <see cref="Circle"/> class
    /// </summary>
    public class CircleException : Exception
    {
        /// <summary>
        /// Initializes the new instance of the <see cref="CircleException"/> with a specified error message
        /// </summary>
        /// <param name="message">Error message</param>
        public CircleException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// Represents a class for creating circles
    /// </summary>
    public class Circle : Base.Shape
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Creates a circle through the radius
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// /// <exception cref="CircleException">The radius is less than or equal to 0</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new CircleException($"A circle with a radius = {radius} equal to 0 or less does not exist");
            }
            Radius = radius;
            Area = Math.PI * radius * radius;
        }
    }
}
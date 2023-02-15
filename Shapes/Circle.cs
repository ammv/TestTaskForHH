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
        private double radius;

        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    throw new CircleException($"A circle with a radius = {radius} equal to 0 or less does not exist");
                }
                radius = value;
            }
        }

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
            this.radius = radius;
        }

        /// <summary>
        /// Calculates the area of a circle through its radius using the formula: pi*r^2
        /// </summary>
        /// <returns>The area of the circle</returns>
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
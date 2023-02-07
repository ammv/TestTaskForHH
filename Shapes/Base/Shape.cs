using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Base
{
    /// <summary>
    /// Represents the base class for shapes
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Calculates the area of the shape
        /// </summary>
        /// <returns>The area of the shape</returns>
        public abstract double GetArea();
    }
}
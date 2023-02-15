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
        /// The area of the shape
        /// </summary>
        public double Area { get; protected set; }
    }
}
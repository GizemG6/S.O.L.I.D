using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class AreaCalculator_Wrong
    {
        public double CalculateArea(object shape)
        {
            if (shape is Circle_Exp)
            {
                Circle_Exp circle = (Circle_Exp)shape;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                return rectangle.Width * rectangle.Height;
            }
            throw new ArgumentException("Unknown shape");
        }
    }

    // To add a new shape, it is necessary to modify the AreaCalculator class, which makes the class vulnerable to modification.
}

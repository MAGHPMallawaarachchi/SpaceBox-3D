using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        public Point Center { get; set; }

        public double GetPerimeter()
        {
            return radius*Math.PI*2;
        }

        public int CountBrailleDots()
        {
            double perimeter = GetPerimeter();

            // Calculate the number of Braille dots required to draw the circle
            double circumferenceInDots = perimeter / 3.0; // Assuming each dot takes up 3 units of space

            return (int)Math.Ceiling(circumferenceInDots);
        }

    }
}
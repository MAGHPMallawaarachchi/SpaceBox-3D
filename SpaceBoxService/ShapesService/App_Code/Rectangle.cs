using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public double GetPerimeter()
        {
            return (length + width) * 2;
        }

        public int CountBrailleDots()
        {
            double perimeter = GetPerimeter();

            // Calculate the number of Braille dots required to draw the rectangle
            double perimeterInDots = perimeter / 3.0; // Assuming each dot takes up 3 units of space

            return (int)Math.Ceiling(perimeterInDots);
        }
    }
}
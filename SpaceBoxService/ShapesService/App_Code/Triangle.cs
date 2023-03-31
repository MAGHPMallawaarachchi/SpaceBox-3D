using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public class Triangle : Shape
    {
        public double side_a { get; set; }

        public double side_b { get; set; }

        public double side_c { get; set; }

        public double GetPerimeter()
        {
            return side_a + side_b + side_c;
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
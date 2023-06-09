﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public class Circle : Shape
    {
        private double radius;

        public ShapeParameters GetParameters()
        {
            return new ShapeParameters { Radius = radius };
        }

        public void SetParameters(ShapeParameters parameters)
        {
            if (parameters.Radius <= 0)
            {
                throw new ArgumentException("Invalid radius for Circle");
            }

            radius = parameters.Radius;
        }

        public int CalculateRequiredDots()
        {
            //standard diameter of a braille dot (1.6mm) + standard space between two braille dots (2.5mm)
            double standard = 4.1;
            return (int)Math.Round(2 * radius * Math.PI / standard);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public class ShapeFactory
    {
        public static Shape CreateShape(string shapeType)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();

                case "rectangle":
                    return new Rectangle();

                case "triangle":
                    return new Triangle();

                default:
                    throw new ArgumentException($"Unsupported shape type: {shapeType}");
            }
        }
    }
}
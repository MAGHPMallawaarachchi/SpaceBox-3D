using SpaceBoxService.ShapesService.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace SpaceBoxService.ShapesService
{
    /// <summary>
    /// Summary description for ShapesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ShapesService : System.Web.Services.WebService
    {

        [WebMethod]
        public int CountBrailleDots(string shapeType, double radius = 0, double length = 0, double width = 0, double side_a = 0, double side_b = 0, double side_c = 0)
        {
            Shape shape = ShapeFactory.CreateShape(shapeType);

            if (shape is Circle circle)
            {
                circle.radius = radius;
                return circle.CountBrailleDots();
            }

            if (shape is App_Code.Rectangle rectangle)
            {
                rectangle.length = length;
                rectangle.width = width;
                return rectangle.CountBrailleDots();
            }

            if (shape is Triangle triangle)
            {
                triangle.side_a = side_a;
                triangle.side_b = side_b;
                triangle.side_c = side_c;
                return triangle.CountBrailleDots();
            }

            throw new ArgumentException($"Unsupported shape type: {shapeType}");
        }

    }
}

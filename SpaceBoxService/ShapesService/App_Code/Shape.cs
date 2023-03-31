using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceBoxService.ShapesService.App_Code
{
    public interface Shape
    {
        double GetPerimeter();
        int CountBrailleDots();
    }

}
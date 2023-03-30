using SpaceBoxService.ShapesService.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string CreateCircle(int radius)
        {
            Circle circle = new Circle();
            return circle.ToBrailleDots(radius);
        }
    }
}

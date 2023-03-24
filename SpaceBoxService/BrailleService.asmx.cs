using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SpaceBoxService
{
    /// <summary>
    /// Summary description for BrailleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BrailleService : System.Web.Services.WebService
    {

        [WebMethod]
        public string[] GetSupportedShapes()
        {
            // implementation for getting the supported shapes
        }

        [WebMethod]
        public string[] GetShapeParameters(string shape)
        {
            // implementation for getting the shape parameters
        }

        [WebMethod]
        public string[] ConvertTextToBraille(string text)
        {
            // implementation for converting text to braille
            // use the BrailleFactory to get the braille representation
            BrailleFactory factory = new BrailleFactory();
            string[] brailleDots = factory.GetBrailleDots(text);
            return brailleDots;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SpaceBoxService
{
    /// <summary>
    /// Summary description for BrailleConverter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BrailleConverter : System.Web.Services.WebService
    {

        [WebMethod]
        public string ConvertToBraille(string input)
        {
            var factory = new BrailleFactory();
            return factory.ConvertToBraille(input);
        }
    }
}

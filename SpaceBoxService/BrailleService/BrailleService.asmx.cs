using SpaceBoxService.BrailleService.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SpaceBoxService.BrailleService
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
        public string ConvertToBraille(string input)
        {
            var translator = new Translator();
            return translator.ConvertToBraille(input);
        }

        [WebMethod]
        public int GetDotsAmount(string input)
        {
            input = ConvertToBraille(input);
            var DotsCounter = new DotsCounter();
            var DotAmount = DotsCounter.GetDotsAmount(input);
            return DotAmount;
        }
    }
}

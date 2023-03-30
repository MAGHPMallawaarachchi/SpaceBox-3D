using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SpaceBox_3D
{
    public partial class Braille : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            BrailleServiceReference.BrailleServiceSoapClient client = new BrailleServiceReference.BrailleServiceSoapClient();
            string output = client.ConvertToBraille(TextBox.Text);
            this.Label1.Text = output;
        }
    }
}

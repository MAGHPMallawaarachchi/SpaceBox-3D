using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SpaceBox_3D
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            BrailleConverter.BrailleConverterSoapClient client = new BrailleConverter.BrailleConverterSoapClient();
            string result = client.ConvertToBraille(TextBox.Text);
            this.Label1.Text = result;
        }
    }
}

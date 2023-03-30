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
            string output = client.ConvertToBraille(txtInput.Text);
            int dotAmount = client.GetDotsAmount(txtInput.Text);

            this.lblBraillePreview.Text = output;
            this.lblDisplayDotAmount.Text = dotAmount.ToString();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblDisplayDotAmount.Text = "";
            txtInput.Text = "";
            lblBraillePreview.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceBox_3D
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Reload();
        }

        protected void ddlSelectShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            if (ddlSelectShape.SelectedValue == "Circle")
            {
                circle.Visible = true;
                rectangle.Visible = false;
                triangle.Visible = false;
            }

            if (ddlSelectShape.SelectedValue == "Rectangle")
            {
                circle.Visible = false;
                rectangle.Visible = true;
                triangle.Visible = false;
            }

            if (ddlSelectShape.SelectedValue == "Triangle")
            {
                circle.Visible = false;
                rectangle.Visible = false;
                triangle.Visible = true;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            if (ddlSelectShape.SelectedValue == "Circle")
            {
                circle.Visible = true;
                rectangle.Visible = false;
                triangle.Visible = false;

                txtRadius.Text = "";
                txtCenterPoint.Text = "";
            }

            if (ddlSelectShape.SelectedValue == "Rectangle")
            {
                circle.Visible = false;
                rectangle.Visible = true;
                triangle.Visible = false;

                txtLength.Text = "";
                txtWidth.Text = "";
            }

            if (ddlSelectShape.SelectedValue == "Triangle")
            {
                circle.Visible = false;
                rectangle.Visible = false;
                triangle.Visible = true;

                txtSide_a.Text = "";
                txtSide_c.Text = "";
                txtSide_b.Text = "";
            } 
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblBraillePreview.Text = "";
            ddlSelectShape.SelectedValue = "Circle";
            lblDisplayDotAmount.Text = "";

            txtRadius.Text = "";
            txtCenterPoint.Text = "";

            txtLength.Text = "";
            txtWidth.Text = "";

            txtSide_a.Text = "";
            txtSide_c.Text = "";
            txtSide_b.Text = "";
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            ShapesServiceReference.ShapesServiceSoapClient client = new ShapesServiceReference.ShapesServiceSoapClient();

            string selectedShape = ddlSelectShape.SelectedValue;

            double radius = 0;
            double length = 0;
            double width = 0;
            double triangleBase = 0;
            double triangleHeight = 0;
            double triangleLength = 0;

            // Get the values of the shape parameters from the textboxes
            if (selectedShape == "Circle")
            {
                radius = double.Parse(txtRadius.Text);
            }
            else if (selectedShape == "Rectangle")
            {
                length = double.Parse(txtLength.Text);
                width = double.Parse(txtWidth.Text);
            }
            else if (selectedShape == "Triangle")
            {
                triangleBase = double.Parse(txtSide_a.Text);
                triangleHeight = double.Parse(txtSide_c.Text);
                triangleLength = double.Parse(txtSide_b.Text);
            }

            // Call the CountBrailleDots method with the appropriate parameters
            int brailleDots = client.CountBrailleDots(selectedShape, radius, length, width, triangleBase, triangleHeight, triangleLength);

            lblDisplayDotAmount.Text = brailleDots.ToString();

        }
    }
}
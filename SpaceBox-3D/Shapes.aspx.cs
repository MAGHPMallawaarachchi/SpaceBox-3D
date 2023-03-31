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
                ShowCircle();
                HideRectangle();
                HideTriangle();
            }

            if (ddlSelectShape.SelectedValue == "Rectangle")
            {
                ShowRectangle();
                HideTriangle();
                HideCircle();
            }

            if (ddlSelectShape.SelectedValue == "Triangle")
            {
                ShowTriangle();
                HideRectangle();
                HideCircle();
            }
        }

        private void HideCircle()
        {
            lblRadius.Visible = false;
            lblCenterPoint.Visible = false;

            txtRadius.Visible = false;
            txtCenterPoint.Visible = false;
        }

        private void HideRectangle()
        {
            lblLength.Visible = false;
            lblWidth.Visible = false;

            txtWidth.Visible = false;
            txtLength.Visible = false;
        }

        private void HideTriangle()
        {
            lblSide_a.Visible = false;
            lblSide_b.Visible = false;
            lblSide_c.Visible = false;

            txtSide_a.Visible = false;
            txtSide_b.Visible = false;
            txtSide_c.Visible = false;
        }

        private void ShowCircle()
        {
            lblRadius.Visible = true;
            lblCenterPoint.Visible = true;

            txtRadius.Visible = true;
            txtCenterPoint.Visible = true;
        }

        private void ShowRectangle()
        {
            lblLength.Visible = true;
            lblWidth.Visible = true;

            txtWidth.Visible = true;
            txtLength.Visible = true;
        }

        private void ShowTriangle()
        {
            lblSide_a.Visible = true;
            lblSide_b.Visible = true;
            lblSide_c.Visible = true;

            txtSide_a.Visible = true;
            txtSide_b.Visible = true;
            txtSide_c.Visible = true;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            if (ddlSelectShape.SelectedValue == "Circle")
            {
                ShowCircle();
                HideRectangle();
                HideTriangle();

                txtRadius.Text = "";
                txtCenterPoint.Text = "";
            }

            if (ddlSelectShape.SelectedValue == "Rectangle")
            {
                ShowRectangle();
                HideTriangle();
                HideCircle();

                txtLength.Text = "";
                txtWidth.Text = "";
            }

            if (ddlSelectShape.SelectedValue == "Triangle")
            {
                ShowTriangle();
                HideRectangle();
                HideCircle();

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
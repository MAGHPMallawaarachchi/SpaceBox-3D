using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpaceBox_3D.ShapesServiceReference;
using SpaceBoxService.ShapesService.App_Code;

namespace SpaceBox_3D
{
    public partial class About : System.Web.UI.Page
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

        protected void btnApply_Click(object sender, EventArgs e)
        {
            ShapesServiceReference.ShapesServiceSoapClient client = new ShapesServiceReference.ShapesServiceSoapClient();

            ShapeParameters shapeParams = new ShapeParameters();

            string selectedShape = ddlSelectShape.SelectedValue;

            // Get the values of the shape parameters from the textboxes
            if (selectedShape == "Circle")
            {
                if (ddlRadius.SelectedValue == "cm")
                    shapeParams.Radius = double.Parse(txtRadius.Text) * 10;
                else
                    shapeParams.Radius = double.Parse(txtRadius.Text);
            }
            else if (selectedShape == "Rectangle")
            {
                if (ddlLength.SelectedValue == "cm")
                    shapeParams.Length = double.Parse(txtLength.Text) * 10;
                else
                    shapeParams.Length = double.Parse(txtLength.Text);

                if (ddlWidth.SelectedValue == "cm")
                    shapeParams.Width = double.Parse(txtWidth.Text) * 10;
                else
                    shapeParams.Width = double.Parse(txtWidth.Text);
            }
            else if (selectedShape == "Triangle")
            {
                if (ddlSide_a.SelectedValue == "cm")
                    shapeParams.SideA = double.Parse(txtSide_a.Text) * 10;
                else
                    shapeParams.SideA = double.Parse(txtSide_a.Text);

                if (ddlSide_b.SelectedValue == "cm")
                    shapeParams.SideB = double.Parse(txtSide_b.Text) * 10;
                else
                    shapeParams.SideB = double.Parse(txtSide_b.Text);

                if (ddlSide_c.SelectedValue == "cm")
                    shapeParams.SideC = double.Parse(txtSide_c.Text) * 10;
                else
                    shapeParams.SideC = double.Parse(txtSide_c.Text);
            }

            int DotAmount = client.CalculateRequiredDotsForShape(selectedShape, shapeParams);
            lblDisplayDotAmount.Text = DotAmount.ToString();

        }
    }
}
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
            ShowCircle();
            HideRectangle();
            HideTriangle();
        }

        protected void ddlSelectShape_SelectedIndexChanged(object sender, EventArgs e)
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

            if ( ddlSelectShape.SelectedValue == "Triangle")
            {
                ShowTriangle();
                HideRectangle();
                HideCircle() ;
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
            lblTraingleBase.Visible = false;
            lblTriangleHeight.Visible = false;
            lblTriangleLength.Visible = false;

            txtTriangleBase.Visible = false;
            txtTriangleLength.Visible = false;
            txtTriangleHeight.Visible = false;
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
            lblTraingleBase.Visible = true;
            lblTriangleHeight.Visible = true;
            lblTriangleLength.Visible = true;

            txtTriangleBase.Visible = true;
            txtTriangleLength.Visible = true;
            txtTriangleHeight.Visible = true;
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

                txtTriangleBase.Text = "";
                txtTriangleHeight.Text = "";
                txtTriangleLength.Text = "";
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

            txtTriangleBase.Text = "";
            txtTriangleHeight.Text = "";
            txtTriangleLength.Text = "";
        }
    }
}
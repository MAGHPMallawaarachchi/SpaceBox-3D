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

        }

        protected void ddlSelectShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSelectShape.SelectedValue != "Rectangle")
            {
                txtRectangleLength.Visible = false;
                txtRectangleWidth.Visible = false;
            }
        }

    }
}
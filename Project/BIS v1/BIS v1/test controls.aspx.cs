using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIS_v1
{
    public partial class test_controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox tbOne = new TextBox();
            Label lblOne = new Label();
            lblOne.ID = "lblId";
            lblOne.Text = "My label";
            lblOne.Width = 200;
            
            lblOne.Style.Add("form-control", "form-control");
            tbOne.ID = "tbId";
            tbOne.Text = "xyz";
           
            pnl.Controls.Add(lblOne);
            pnl.Controls.Add(tbOne);

        }
    }
}
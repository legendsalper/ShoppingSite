using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {       
        ArrayList SPI = (ArrayList)Session["SelectedProductIndices"];
        
        if (SPI == null)
        {
            err.Text = "Ben boşum";
        }
        else
        {
            string id = (string)SPI[0];
            Product p1 = (Product)Session["Product1"];
            Vendor.Text = p1.Vendor.ToString();
            type.Text = p1.Type.ToString();
            productname.Text = (p1.Vendor.ToString() + " " + p1.Model.ToString());
            imgg.ImageUrl = p1.ImageUrl;
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string id = Request.QueryString["id"];
        if (id == "1")
        {
            Product p1 = (Product)Session["Product1"];
            Vendor.Text = p1.Vendor.ToString();
            type.Text = p1.Type.ToString();
            productname.Text = (p1.Vendor.ToString() + " " + p1.Model.ToString());
            imgg.ImageUrl = p1.ImageUrl;

        }
        else if (id == null)
        {
            err.Text = "Please specify a product ID!!!";
            
        }
        else if (id == "2")
        {
            Product p2 = (Product)Session["Product2"];
            Vendor.Text = p2.Vendor.ToString();
            type.Text = p2.Type.ToString();
            productname.Text = (p2.Vendor.ToString() + " " + p2.Model.ToString());
        }
        else if (id == "3")
        {
            Product p3 = (Product)Session["Product3"];
            Vendor.Text = p3.Vendor.ToString();
            type.Text = p3.Type.ToString();
            productname.Text = (p3.Vendor.ToString() + " " + p3.Model.ToString());
        }
        else if (id == "4")
        {
            Product p4 = (Product)Session["Product4"];
            Vendor.Text = p4.Vendor.ToString();
            type.Text = p4.Type.ToString();
            productname.Text = (p4.Vendor.ToString() + " " + p4.Model.ToString());
        }
        else if (id == "5")
        {
            Product p5 = (Product)Session["Product5"];
            Vendor.Text = p5.Vendor.ToString();
            type.Text = p5.Type.ToString();
            productname.Text = (p5.Vendor.ToString() + " " + p5.Model.ToString());
        }
        else
        {
            err.Text = "Invalid Product ID!!!";
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Cart.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }

    protected void cartt_Click(object sender, EventArgs e)
    {
        ArrayList SelectedProductIndices = new ArrayList();
        string id = Request.QueryString["id"];
        if (id == "1")
        {
            Session["id1"] = SelectedProductIndices.Add(id);
        }
        else if (id == "2")
        {
            Session["id2"] = SelectedProductIndices.Add(id);
        }
        else if (id == "3")
        {
            Session["id3"] = SelectedProductIndices.Add(id);
        }
        else if (id == "4")
        {
            Session["id4"] = SelectedProductIndices.Add(id);
        }
        else if (id == "5")
        {
            Session["id5"] = SelectedProductIndices.Add(id);
        }
    }

}
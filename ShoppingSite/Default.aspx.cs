using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            // Create product objects.
            Product product1 = new Product(1, "phone", "samsung", "c270", "ilk");
            Product product2 = new Product(2, "phone", "samsung", "e250i", "ikinci");
            Product product3 = new Product(3, "laptop", "toshiba", "l500", "ucuncu");
            Product product4 = new Product(4, "laptop", "lenovo", "g550", "dorduncu");
            Product product5 = new Product(5, "netbook", "acer", "fo200", "besinci");
            
            // Add objects to session state.
            Session["Product1"] = product1;
            Session["Product2"] = product2;
            Session["Product3"] = product3;
            Session["Product4"] = product4;
            Session["Product5"] = product5;

            //bunu anlamadım hala
            /* Add rows to list control.			
            lstItems.Items.Add(piece1.Name);
            lstItems.Items.Add(piece2.Name);
            lstItems.Items.Add(piece3.Name);*/
        } 


        HttpCookie cookie = Request.Cookies["UserInfo"];
        //which page to be displayed
        if (cookie == null)
        {
            firstdiv.Visible = true;
            seconddiv.Visible = false;
        }
        else
        {
            firstdiv.Visible = false;
            seconddiv.Visible = true;
            nameniz.Text = cookie.Value;
        }       

    }

    protected void here(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }

    protected void showcart_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Cart.aspx");
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("UserInfo");
        cookie.Expires = DateTime.Now.AddDays(-7);
        Response.Cookies.Add(cookie);
        Response.Redirect("~/Default.aspx");
    }

    protected void c270_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ProductInfo.aspx?id=1");
    }

    protected void e250i_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ProductInfo.aspx?id=2");
    }

    protected void l500_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ProductInfo.aspx?id=3");
    }

    protected void g550_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ProductInfo.aspx?id=4");
    }

    protected void fo200_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/ProductInfo.aspx?id=5");
    }
}
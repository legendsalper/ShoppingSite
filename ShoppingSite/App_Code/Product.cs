using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public int ProductID;
    public string Type;
    public string Vendor;
    public string Model;
    public string ImageUrl;
    
    

    public Product(int productID, string type, string vendor, string model, string ımageUrl)
    {
        this.ProductID = productID;
        this.Type = type;
        this.Vendor = vendor;
        this.Model = model;
        this.ImageUrl = ımageUrl;
    }

    ArrayList SelectedProductIndices = new ArrayList();


}
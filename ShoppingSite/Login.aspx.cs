using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Log_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("UserInfo");
        cookie.Value = UserName.Text;
        cookie.Expires = DateTime.Now.AddMonths(1);        
        Response.Cookies.Add(cookie);
        Response.Redirect("~/Default.aspx");
    }
}
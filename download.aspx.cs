using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

public partial class download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String val = Request.QueryString["fname"];

        //TextBox1.Text = val;
        WebClient client= new WebClient();
        client.DownloadFile("D:/uploaded/"+val, @"C:\check\"+val);

       

        }       

     




    
}
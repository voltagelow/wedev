using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data.SqlClient;

public partial class download : System.Web.UI.Page
{
    int item;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        String val = Request.QueryString["fname"];
        item = Convert.ToInt32(Request.QueryString["itemid"]);

        //TextBox1.Text = val;
        WebClient client= new WebClient();
        client.DownloadFile("D:/uploaded/"+val, @"C:\check\"+val);

       

        }







    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ratevalue = RadioButtonList1.SelectedIndex;

        test1.InnerText = ratevalue.ToString();

        ratevalue++;
        SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
        sql_con.Open();
        SqlCommand cmd = new SqlCommand("insert into ratings values(" + item + ",'" + Session["username"].ToString() + "'," + ratevalue + ",getdate())", sql_con);
        cmd.ExecuteNonQuery();


        SqlCommand cmd1 = new SqlCommand("update items set itemrating = (select avg(rating) from ratings group by  itemid having itemid=" + item + ") where itemid=" + item, sql_con);
        cmd1.ExecuteNonQuery();

        Response.Write("<script language='javascript'>alert('Thanks for rating us! You are beign redirected to home page.');</script>");
        
        sql_con.Close();

        Response.Redirect("loginsuccessful.aspx");
    }
}
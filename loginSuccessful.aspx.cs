//garvitthejain

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        

    }

    public string getWhileLoopData()
    {
        string htmlStr = "";
        String username = Session["username"].ToString();
        String password = Session["password"].ToString();
        SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
        sql_con.Open();
      
        SqlCommand cmd = new SqlCommand("select *  from ratings where username='"+username+"' order by daterated desc;", sql_con);
        SqlDataReader reader = null;
        reader = cmd.ExecuteReader();

    

         while (reader.Read())
         {
             int ItemId = reader.GetInt32(0);
              
              String userename = reader.GetString(1);

              int rating = reader.GetInt32(2);
              DateTime daterated = reader.GetDateTime(3);
                htmlStr += "<tr><td>" + ItemId + "</td><td>" + userename + "</td><td>" + rating + "</td><td><a href='download.aspx?fname="+daterated+"' onclick=getId("+daterated+") runat='Server'>" + daterated + "</td></tr></a>";


         }

        


        sql_con.Close();
        Console.Read();
       
        return htmlStr;
    }









    public string recommendeddata()
    {
        string htmlStr = "";
     



        SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
        sql_con.Open();
        SqlCommand cmd = new SqlCommand("select itemname,itemlink,itemauthor,itemrating,itemcategory,itemtopic,timereq,itemid from items order by itemrating", sql_con);
        SqlDataReader reader = null;
        reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            String itemnam = reader.GetString(0);
            String itemlink = reader.GetString(1);
           
            String itemauthr = reader.GetString(2);
         int itemrate = reader.GetInt32(3);
            String itemcate = reader.GetString(4);
            String itemtop = reader.GetString(5);
           
            
            int timereq = reader.GetInt32(6);
            

            htmlStr += "<tr><td>" + itemnam + "</td><td>" + itemrate + "</td><td>" + itemauthr + "</td><td>"+ itemcate + "</td><td>"+ itemtop + "</td><td>"+ timereq + "</td><td><a href='download.aspx?fname=" + itemlink + "'  runat='Server'>" + itemlink
 + "</td></tr></a>";

            
           

        }

        sql_con.Close();
        Console.Read();

        return htmlStr;
    }
























    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }
}
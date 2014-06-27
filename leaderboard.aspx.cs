using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class leaderboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    public string getWhileLoopData()
    {
        string htmlStr = "";

        SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
        sql_con.Open();
        SqlCommand cmd = new SqlCommand("select top 100 * from customers", sql_con);
        SqlDataReader reader = null;
        reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            int usereId = reader.GetInt32(0);
            String ItemId = reader.GetString(1);
            String rating = reader.GetString(2);
            String daterated = reader.GetString(3);
            htmlStr += "<tr><td>" + usereId + "</td><td>" + ItemId + "</td><td>" + rating + "</td><td><a href='download.aspx?fname=" + daterated + "' onclick=getId(" + daterated + ") runat='Server'>" + daterated + "</td></tr></a>";


        }


        sql_con.Close();
        Console.Read();

        return htmlStr;
    }


}
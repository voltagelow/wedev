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





    public string getLeaderBoard()
    {
        string htmlStr = "";
        String usename = Session[0].ToString();
        String passs = Session[1].ToString();

        SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
        sql_con.Open();
        SqlCommand cmd = new SqlCommand("select top 10 sum(rating) as total_rating,i.ItemId,i.ItemAuthor ,i.ItemName from Items i inner join ratings r on i.ItemId=r.itemid group by i.ItemId,i.ItemAuthor ,i.ItemName order by total_rating desc ", sql_con);
        SqlDataReader reader = null;
        reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            int sum = reader.GetInt32(0);
          //int itemId = reader.GetInt32(1);
            String itemAuthor = reader.GetString(2);
            String itemname = reader.GetString(3);
            htmlStr += "<tr><td>" + itemAuthor + "</td><td>" + itemname + "</td><td>" + sum + "</td><td> ";


        }


        sql_con.Close();
        Console.Read();

        return htmlStr;
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class search : System.Web.UI.Page
{
    private String strConnection = "Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            BindCategorydropdown();
        }

    }
    protected void BindCategorydropdown()
    {
        //conenction path for database
        SqlConnection con = new SqlConnection(strConnection);
        con.Open();
        SqlCommand cmd = new SqlCommand("select distinct category from category", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        ddlCategory.DataSource = ds;
        ddlCategory.DataTextField = "Category";
        ddlCategory.DataValueField = "Category";
        ddlCategory.DataBind();
        ddlCategory.Items.Insert(0, new ListItem("--Select--", "0"));
        ddlTopic.Items.Insert(0, new ListItem("--Select--", "0"));

    }
    

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        String CategoryID = ddlCategory.SelectedValue;
        SqlConnection con = new SqlConnection(strConnection);
        con.Open();
        SqlCommand cmd = new SqlCommand("select Topic from Category where Category='" + CategoryID + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        ddlTopic.DataSource = ds;
        ddlTopic.DataTextField = "Topic";
        ddlTopic.DataValueField = "Topic";
        ddlTopic.DataBind();
        ddlTopic.Items.Insert(0, new ListItem("--Select--", "0"));

    }
    

    protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
    {
        String TopicID = ddlTopic.SelectedValue;
        SqlConnection con = new SqlConnection(strConnection);
    }

    
    protected void Button2_Click(object sender, EventArgs e)
    {

        string ddlC = ddlCategory.SelectedValue;
        string ddlT = ddlTopic.SelectedValue;
        String time = hours.Value;
        int timeVal;
        timeVal = Convert.ToInt32(time);
        Response.Redirect("search.aspx?category=" + ddlC + "&topic=" + ddlT + "&timereq=" + timeVal+"&flag=1");
    }

    public string showhere()
    {
        if (Request.QueryString["flag"] == "1")
        {
            string vcategory = Request.QueryString["category"];
            string vtopic = Request.QueryString["topic"];
            string vtime = Request.QueryString["timereq"];
            int timeVal = Convert.ToInt32(vtime);


            String htmlStr = "";
            int lowerTime = (int)Math.Ceiling((timeVal * 0.8) - 1);
            int upperTime = (int)Math.Ceiling(timeVal * 1.2);

            SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
            sql_con.Open();
            SqlCommand cmd = new SqlCommand("select top 10 itemName, ItemLink,lastratedon,itemrating,itemauthor,Timereq from items where itemcategory='"+vcategory+"' and itemtopic ='" + vtopic + "' and timereq>" + lowerTime + " and timereq<" + upperTime + "", sql_con);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                String itemname = reader.GetString(0);
                String Itemlink = reader.GetString(1);
                DateTime lastratedon = reader.GetDateTime(2);
                
                int itemrating = reader.GetInt32(3);
                String itemauthor = reader.GetString(4);
                int reqtime = reader.GetInt32(5);
                htmlStr += "<tr><td>" + itemname + "</td><td><a href='download.aspx?fname=" + Itemlink + "' runat='Server'>" + Itemlink + "</a></td><td>" + lastratedon + "</td><td>" + itemrating + "</td><td>" + itemauthor + "</td><td>" + reqtime + "</td></tr>";

            }

            sql_con.Close();
            return htmlStr;
        }
        return "";
    }

}
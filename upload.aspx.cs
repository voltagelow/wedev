using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class upload : System.Web.UI.Page


  

{
    string ddlT;
    string ddlC;
    protected void Page_Load(object sender, EventArgs e)
    {
                String user = Session["username"].ToString();

                head.InnerText = "Hello" +"  " +user +"  "+ "upload your content here";


                if (!IsPostBack)
                {
                    BindCategorydropdown();
                }
    
    
    
    }

    protected void BindCategorydropdown()
    {
        //conenction path for database
        SqlConnection con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
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
        SqlConnection con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
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
        SqlConnection con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
    }


   











    protected void Upload(object sender, EventArgs e)
    {
        String Iname = ItemName.Value;
     
        String timeReq = ItemTime.Value;


 
      // string a=ItemName.Value;
       // string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
        //String RelativePath = AbsolutePath.Replace(Request.ServerVariables[""], String.Empty);
        if (uploadfile.HasFile)
        {

            ddlC = ddlCategory.SelectedValue;
            ddlT = ddlTopic.SelectedValue;


            uploadfile.SaveAs("D:\\uploaded\\" + uploadfile.PostedFile.FileName);

            String filenmae=uploadfile.PostedFile.FileName;

            SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
            sql_con.Open();
            SqlCommand cmd = new SqlCommand("insert into Items values('"+Iname+"','"+filenmae+"',1,'"+User+"',0,'"+ddlC+"','"+ddlT+"',getdate(),'"+timeReq+"',getdate())", sql_con);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();

            sql_con.Close();



        }
       // SqlCommand cmd = new SqlCommand("insert into FilesTable(FileName,FilePath) values(@Name,@Path)", con);
        //cmd.Parameters.AddWithValue("@Name", filename);
        //cmd.Parameters.AddWithValue("@Path", "Files/" + filename);
        //cmd.ExecuteNonQuery();
        //con.Close();
        //BindGridviewData();

        

            //test.Value = "shubhamj";
           // Console.WriteLine("suxcess");

        


    


    }
}
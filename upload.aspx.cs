using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Upload(object sender, EventArgs e)
    {
        String Iname = ItemName.Value;
        String ICatagory = ItemCategory.Value;
        String topic = ItemTopic.Value;


 
      // string a=ItemName.Value;
       // string filename = Path.GetFileName(FileUpload.PostedFile.FileName);
        //String RelativePath = AbsolutePath.Replace(Request.ServerVariables[""], String.Empty);
        if (uploadfile.HasFile)
        {




            uploadfile.SaveAs("D:\\uploaded\\" + uploadfile.PostedFile.FileName);

            String filenmae=uploadfile.PostedFile.FileName;

            SqlConnection sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
            sql_con.Open();
            SqlCommand cmd = new SqlCommand("insert into Items values('"+Iname+"','"+filenmae+"',1,'shubham',5,'"+ICatagory+"','"+topic+"',getdate(),40,getdate())", sql_con);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection sql_con;

    protected void Page_Load(object sender, EventArgs e)
    {
        sql_con = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
        sql_con.Open();
    }

    protected void signin(object sender, EventArgs e)
    {
        
    }



    protected void Button1_Click1(object sender, EventArgs e)
    {
        String username = r_username.Value;
        String name = r_name.Value;
        String email = r_email.Value;
        String password = r_password.Value;
        String repassword = r_password2.Value;
        
        SqlCommand cmd = new SqlCommand("insert into Scratch..temp_crs values('"+username+"','"+name+"','"+email+"','"+password+"')", sql_con);
        
        if(password!=repassword)
        {
            wp.Visible=true;
            return;
        }

        if (cmd.ExecuteNonQuery()<=0)
        {
            
        }
        sql_con.Close();
        Response.Redirect("Default2.aspx");
    }
    
}
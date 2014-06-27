using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection connection;
    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection("Data Source=Boron\\ag;Initial Catalog=Scratch;Integrated Security=SSPI");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        String username = l_username.Value;
        String password = l_password.Value;
        using (connection)
        {
            SqlCommand command = new SqlCommand(
              "SELECT username, password FROM temp_crs where username='"+username+"' and password='"+password+"';",
              connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Response.Redirect("loginSuccessful.aspx");
            }
            else
            {
                wp.Visible = true;
            }
            reader.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lgn_Click(object sender, EventArgs e)
    {
        SqlConnection cn = cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf\";Integrated Security=True");
        cn.Open();
        string a = username.Text;
        string b = password.Text;
        string h="Select * from student where s_name='"+a+"' and password='"+b+"'";
        SqlCommand cmd = new SqlCommand(h);

        cmd.Connection = cn;

        int OBJ = Convert.ToInt32(cmd.ExecuteScalar());

        if (OBJ > 0)

        {

            Session["name"] = username.Text;
            HttpCookie aCookie = new HttpCookie("name");
            aCookie.Value = username.Text;
            aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);
            
            
            Response.Redirect("default3.aspx");

        }

        else

        {

            Label1.Text = "Invalid username or password";

            

        }

    }
}
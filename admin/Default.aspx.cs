using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*if (uname.Text == "Himansh12" && passwd.Text == "radhasoamimay23")
        {
            FormsAuthentication.RedirectFromLoginPage(uname.Text, false);
            Response.Redirect("~/admin/list_student.aspx");
        }
        else
        {
            Label1.Text = "try again";
        }*/
        Session["uname"] = uname.Text;
        Response.Redirect("home.aspx");

        /*SqlConnection cn = cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf\";Integrated Security=True");
        cn.Open();
        string a = uname.Text;
        string b = passwd.Text;
        string h = "Select * from student where s_name='" + a + "' and password='" + b + "'";
        SqlCommand cmd = new SqlCommand(h);

        cmd.Connection = cn;

        int OBJ = Convert.ToInt32(cmd.ExecuteScalar());

        if (OBJ > 0)
        {

            //Session["name"] = username.Text;

            Response.Redirect("default3.aspx");

        }

        else
        {

            Label1.Text = "Invalid username or password";



        }
        */
    }
}
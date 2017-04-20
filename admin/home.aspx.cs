using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        SqlConnection cn;

        cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf\";Integrated Security=True");
        cn.Open();

        string stmt = "SELECT COUNT(*) FROM dbo.hostel";
        int count = 0;
        SqlCommand cmdCount = new SqlCommand(stmt, cn);
        count = (int)cmdCount.ExecuteScalar();
        Label2.Text = count.ToString();


        string stmt1 = "SELECT COUNT(*) FROM dbo.student";
        int count1 = 0;
        SqlCommand cmdCount1 = new SqlCommand(stmt1, cn);
        count1 = (int)cmdCount.ExecuteScalar();
        Label4.Text = count1.ToString();

    }
}
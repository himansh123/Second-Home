using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class add_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Redirect("Default.aspx");
        }

    }
    protected void addstudent_Click(object sender, EventArgs e)
    {
        SqlConnection cn;

        cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf\";Integrated Security=True");
        cn.Open();




        // string sid, hid, r_id, s_name, dob1, college1,contact_no1,parents_c_no1, joining_date1;
        //s_name = username.Text;
        //dob1 = dob.Text;
        //string pass = passwd.Text;
        //college1 = college.Text;
        //contact_no1 = contact_no.Text;
        //parents_c_no1 = parentsno.Text;
        //joining_date1 = joindate.Text;
        //string hostel;

        //  cn.Open();
        string h = "insert into student(h_id,r_id,s_name,password,dob,college,contact_no,parents_c_no,joining_date) values('" + hostel.Text + "','" + room.Text + "','" + s_name.Text + "','" + passwd.Text + "','" + dob.Text + "','" + college.Text + "','" + contact_no.Text + "','" + p_contact_no.Text + "','" + join_date.Text + "')";
        SqlCommand cmd = new SqlCommand(h, cn);
        int a = cmd.ExecuteNonQuery();
        cn.Close();
        // Response.Redirect("Default.aspx");
        if (a > 0)
        {
            Response.Redirect("list_students.aspx");
        }
            
        

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
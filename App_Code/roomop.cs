using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for roomop
/// </summary>
public class roomop
{
    SqlConnection cn;
	public roomop()
	{
        cn = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf;Integrated Security=True");
	}

    protected int dbupdate(string rid,string no_student,string rent,string ac,string filled,string empty)
    { 
        
        cn.Open();
        string sql = "UPDATE student SET rid='" + rid + "',no_student='" + no_student + "',rent='" + rent + "',ac=" + ac + "',filled='" + filled + "',empty='" + empty + "'WHERE rid='" + rid + "'";
        SqlCommand cmd = new SqlCommand(sql, cn);
        int a=cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
        return a; 

    }
    protected int dbdelete(string rid)
    {   
        string sqlx = "delete from room where sid='"+rid+"'";
        cn.Open();
        SqlCommand cmd = new SqlCommand(sqlx, cn);
        int b=cmd.ExecuteNonQuery();
        cn.Close();
        //MsgBox(" Data deleted from login table")
        return b;
    }
    protected int dbinsert(string sid, string hid, string r_id, string s_name, string dob, string college, string contact_no, string parents_c_no, string joining_date)
    {
        cn.Open();
        //string h="insert into room values('"+rid+"','"+no_student+"','"+rent+"',"+ac+"','"+filled+"','"+empty+"')";
        //SqlCommand cmd = new SqlCommand(h, cn);
        //int a=cmd.ExecuteNonQuery();
        cn.Close();
        int a=0;
       // Response.Redirect("Default.aspx");
        return a;   
    }
    public void dbselect(string rid)
    {
        cn.Open();

        SqlCommand cmd = new SqlCommand("Select * from room", cn);
        DataSet ds = new DataSet();
         
        
        //grd_dataset.DataSource = cmd.ExecuteReader();
        //grd_dataset.DataBind();

    }




    
}
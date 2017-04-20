using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dboperation
/// </summary>
public class dboperation
{
    SqlConnection cn;
    public dboperation() {

        cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf\";Integrated Security=True");


    }



    protected int dbupdate(string sid, string hid, string r_id, string s_name, string dob, string college, string contact_no, string parents_c_no, string joining_date)
    { 
        
        cn.Open();
        string sql = "UPDATE student SET hid='"+hid+"',rid='"+r_id+"',s_name='"+s_name+"',dob='"+dob+"',college='"+college+"',contact_no='"+contact_no+"',parents_c_no='"+parents_c_no+"',joining_date='"+joining_date+" WHERE sid='"+sid+"'";
        SqlCommand cmd = new SqlCommand(sql, cn);
        int a=cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
        return a; 

    }
    protected int dbdelete(string sid)
    {   
        string sqlx = "delete from student where sid='"+sid+"'";
        cn.Open();
        SqlCommand cmd = new SqlCommand(sqlx, cn);
        int b=cmd.ExecuteNonQuery();
        cn.Close();
        //MsgBox(" Data deleted from login table")
        return b;
    }
    public int dbinsert(string sid, string hid, string r_id, string s_name, string dob, string college, string contact_no, string parents_c_no, string joining_date)
    {
        cn.Open();
        string h="insert into student values('"+sid+"','"+hid+"','"+r_id+"',"+s_name+"','"+dob+"','"+college+"','"+contact_no+"','"+parents_c_no+"','"+joining_date+")";
        SqlCommand cmd = new SqlCommand(h, cn);
        int a=cmd.ExecuteNonQuery();
        cn.Close();
       // Response.Redirect("Default.aspx");
        return a;   
    }
    public DataSet dbselect()
    {
        cn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter("Select * from student ", cn);
        DataSet ds = new DataSet();
        cmd.Fill(ds, "student");

        cn.Close();
        return ds;        //SqlDataAdapter dataAdapter = new SqlDataAdapter(select_query, con);
        //DataSet ds = new DataSet();
        //dataAdapter.Fill(ds, "s_info");
        //con.Close();
        //return ds;

    }






}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// Summary description for hostelop

public class hostelop
{

    SqlConnection cn;
    public hostelop()
    {
        cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"F:\\college\\college\\sem4\\wt\\Visual studio websites\\WebSite1\\App_Data\\Database2.mdf\";Integrated Security=True");
     
     
    }
    
    public DataSet dbselect(string a)
    {
        cn.Open();   
        SqlDataAdapter cmd = new SqlDataAdapter("Select * from hostel where address='"+a+"'", cn);
        DataSet ds = new DataSet();
        cmd.Fill(ds, "hostel");
       
        cn.Close();
        return ds;
        //SqlDataAdapter dataAdapter = new SqlDataAdapter(select_query, con);
        //DataSet ds = new DataSet();
        //dataAdapter.Fill(ds, "s_info");
        //con.Close();
        //return ds;

    }
    public DataSet dbselectall()
    {
        cn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter("Select * from hostel", cn);
        DataSet ds = new DataSet();
        cmd.Fill(ds, "hostel");

        cn.Close();
        return ds;
        //SqlDataAdapter dataAdapter = new SqlDataAdapter(select_query, con);
        //DataSet ds = new DataSet();
        //dataAdapter.Fill(ds, "s_info");
        //con.Close();
        //return ds;

    }


}

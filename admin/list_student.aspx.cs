using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class list_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        dboperation h = new dboperation();
        DataSet ds = h.dbselect();
        showdata.DataSource = ds;
        showdata.DataMember = "student";
        showdata.DataBind();
    }
    protected void showdata_SelectedIndexChanged(object sender, EventArgs e)
    {
        //hostelop h = new hostelop();
        
    }
}
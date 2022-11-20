using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace showGrid
{
    public partial class showGrid : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        Commands cmnds=new Commands();
        protected void Page_Load(object sender, EventArgs e)
        
        {
            if (!IsPostBack)
            {
                cmnds.slctName("Products").Fill(dt);
                Drpdwnlist.DataSource = dt;
                Drpdwnlist.DataTextField = "ProductName";
                Drpdwnlist.DataBind();
            }

        }

        protected void grid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Drpdwnlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmnds.alldata(Drpdwnlist.SelectedItem.Value).Fill(dt);
            grid.DataSource = dt;
            grid.DataBind();
            
        }
    }
}
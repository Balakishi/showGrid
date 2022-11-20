using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace showGrid
{
    public class Commands
    {
       SqlConnection connect = new SqlConnection(Connection.GetConnect);
       SqlCommand cmd;
       DataTable data = new DataTable();
        string query;
        public SqlDataAdapter slctName(string tname)
        {
            connect.Open();
            query = "select ProductName from " + tname;
            cmd =new SqlCommand(query,connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           connect.Close();
            return adapter;
        }

        public SqlDataAdapter alldata( string name)
        {
            connect.Open();
            query = "select * from Products where ProductName = '" + name + "'";
            cmd = new SqlCommand(query, connect);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            connect.Close();
            return adapter1;
        }
    }
    }

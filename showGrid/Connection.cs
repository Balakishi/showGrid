using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace showGrid
{
    public class Connection
    {
      
            public static string GetConnect
            {
                get { return "Data Source =HOME-PC\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True"; }
            }
        
    }
}
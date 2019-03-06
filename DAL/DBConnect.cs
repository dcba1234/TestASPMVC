using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected static SqlConnection con = new SqlConnection(@"Data Source = (local) ; Initial Catalog = MVC ;Integrated Security = True ");
        //Data Source=DESKTOP-GNRSP8N\SQLEXPRESS;Initial Catalog=test;Integrated Security=True
    }
}

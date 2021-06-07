using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pro
{
    class sqlconnection
    {
        //SqlConnection con;
        public SqlConnection connectionMethod()
        {
            return new SqlConnection(@"Data Source=ADMIN;Initial Catalog=ProPlan;Integrated Security=True");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Satış_Takip_Uyg
{
  

    public static class Db
    {
        private static readonly string _cs =
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static SqlConnection Open()
        {
            var con = new SqlConnection(_cs);
            con.Open();
            return con;
        }
    }
}

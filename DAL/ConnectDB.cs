using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectDB
    {
        
        public static SqlConnection connection()
        {
            string connectionString = "Database=QLVATLIEU;Server=ADMIN\\SQLEXPRESS; User id=sa; Password=123;TrustServerCertificate=true";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
            
        }
    }
}

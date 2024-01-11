using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Employee GetEmployeeByEmail(string email, string password)
        {
            Employee employee = null;
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from NHANVIEN where EMAIL = @email and PASSWORD = @pass";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", password);
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int manv = Convert.ToInt32(reader.GetInt32(0));
                            string tenNV = reader.GetString(1);
                            int sdt = Convert.ToInt32(reader.GetOrdinal("SDTNV"));
                            string passR = reader.GetString(3);
                            string emailR = reader.GetString(4);
                            employee = new Employee(manv,tenNV,sdt,passR,emailR);
                        }        
                    }
                }
            }
            return employee;
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReportDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public List<MyItem> GetMyItems(string dateTimeStart, string dateTimeEnd)
        {
            List<MyItem> items = new List<MyItem>();
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "SELECT cdh.mavatlieu, v.tenvatlieu, SUM(cdh.soluong) AS SoLuongBan, SUM(v.dongia * cdh.soluong) AS TongTienBan FROM CHITIET_HOADON cdh JOIN hoadon dh ON dh.mahoadon = cdh.mahoadon JOIN vatlieu v on v.mavatlieu = cdh.mavatlieu WHERE dh.created_time BETWEEN @startDateTime AND @toDateTime GROUP BY cdh.MAVATLIEU, v.TENVATLIEU";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@startDateTime", dateTimeStart);
                    cmd.Parameters.AddWithValue("@toDateTime", dateTimeEnd);
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                          
                            int idItem = Convert.ToInt32(reader.GetInt32(0));
                            int quantityItem = Convert.ToInt32(reader.GetInt32(2));
                            int priceItem = Convert.ToInt32(reader.GetInt32(3));
                        
                            string tenvatlieu = reader.GetString(1);
                            MyItem item = new MyItem("", tenvatlieu, 0, idItem, quantityItem, priceItem);
                            items.Add(item);

                        }
                    }

                    return items;  
                }
            }
        }
    }
}

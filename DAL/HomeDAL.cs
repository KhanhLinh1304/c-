using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class HomeDAL
    {
        SqlConnection conn;
        SqlCommand cmd; //bắt đầu truy vấn
        SqlDataAdapter adapter; // chuyển dũ liệu về
        DataTable dt; //lưu trữ dữ liệu
        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
       
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from VATLIEU";
                using (cmd = new SqlCommand(sql, conn))
                {
                    using (adapter = new SqlDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        adapter.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            int maVL =Convert.ToInt32(dr[0].ToString());
                            string tenVL = dr[1].ToString();
                            double giaVL = Convert.ToDouble(dr[2].ToString());
                            int soluong = Convert.ToInt32(dr[3].ToString());
                            string loaiVL =(dr[4].ToString());
                            string donvitinh = dr[5].ToString();
                            Product product = new Product(maVL, tenVL, giaVL, soluong, loaiVL, donvitinh);
                            products.Add(product);
                        }
                    }
                }   
               
            }
            return products;        
        }

       public List<MyItem> GetObject(string madonhang)
        {
            List<MyItem> items = new List<MyItem>();

            using (conn = ConnectDB.connection())
            {
                conn.Open();

                string sql = "select i.*, v.donvitinh,v.tenvatlieu,v.dongia from chitiet_hoadon i inner join vatlieu v on i.mavatlieu=v.mavatlieu where mahoadon = @maHoaDon";

                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", madonhang);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try {
                            while (reader.Read())
                            {
                                int idItem = Convert.ToInt32(reader["mavatlieu"]);
                                int quantityItem = Convert.ToInt32(reader["soluong"]);
                                int priceItem = Convert.ToInt32(reader["tongtien"]);
                                string donvitinh = reader["donvitinh"].ToString();
                                string tenvatlieu = reader["tenvatlieu"].ToString();
                                int dongia = Convert.ToInt32(reader["dongia"]);

                                MyItem item = new MyItem(donvitinh, tenvatlieu, dongia, idItem, quantityItem, priceItem);
                                items.Add(item);
                            }
                        }catch(Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");

                        }

                    }

                }
            }

            return items;
        }

    }
}

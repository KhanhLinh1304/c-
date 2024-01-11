using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;


        public List<Product> getListProduct()
        {
            List<Product> list = new List<Product>();
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string connectionStr = "select * from VATLIEU ";
                using (cmd = new SqlCommand(connectionStr, conn))
                {
                  
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int maVL = Convert.ToInt32(reader.GetInt32(0));
                            string tenVL = reader.GetString(1);
                            double giaVL = Convert.ToInt32(reader.GetInt32(2));
                            int soluong = Convert.ToInt32(reader.GetInt32(3));
                            string loaiVL = reader.GetString(4);
                            string donvitinh = reader.GetString(5);
                            Product product = new Product(maVL, tenVL, giaVL, soluong, loaiVL, donvitinh);
                            list.Add(product);
                        }
                    }
                    return list;

                }

            }
        }

        public List<Product> FillterProductByIdLoaiVL(string LoaiVL)
        {
            List<Product> list = new List<Product>();
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string connectionStr = "select * from VATLIEU where LOAIVATLIEU like @LOAIVATLIEU ";
                using(cmd = new SqlCommand(connectionStr, conn)) {
                      cmd.Parameters.AddWithValue("@LOAIVATLIEU","%"+LoaiVL+"%");
                    using(reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int maVL = Convert.ToInt32(reader.GetInt32(0));
                            string tenVL =reader.GetString(1);
                            double giaVL = Convert.ToInt32(reader.GetInt32(2));
                            int soluong = Convert.ToInt32(reader.GetInt32(3));
                            string loaiVL = reader.GetString(4);
                            string donvitinh = reader.GetString(5);
                            Product product = new Product(maVL, tenVL, giaVL, soluong, loaiVL,donvitinh);
                            list.Add(product);
                        }
                    }
                    return list;
                     
                }

            }
        }
        public List<Product> SearchByNameVL(string TenLoaiVL)
        {
            List<Product> list = new List<Product>();
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string connectionStr = "select * from VATLIEU where TENVATLIEU like @TENVATLIEU ";
                using (cmd = new SqlCommand(connectionStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TENVATLIEU", "%" + TenLoaiVL + "%");
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int maVL = Convert.ToInt32(reader.GetInt32(0));
                            string tenVL = reader.GetString(1);
                            double giaVL = Convert.ToInt32(reader.GetInt32(2));
                            int soluong = Convert.ToInt32(reader.GetInt32(3));
                            string loaiVL = reader.GetString(4);
                            string donvitinh = reader.GetString(5);
                            Product product = new Product(maVL, tenVL, giaVL, soluong, loaiVL, donvitinh);
                            list.Add(product);
                        }
                    }
                    return list;

                }

            }
        }
        public void UpdateQuantityProduct(int soluong, int mavl)
        {
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string connectionStr = "UPDATE VATLIEU SET SOLUONG=@soluong  WHERE MAVATLIEU = @maVL";
                using (cmd = new SqlCommand(connectionStr, conn))
                {
                    cmd.Parameters.AddWithValue("@soluong", soluong);
                    cmd.Parameters.AddWithValue("@mavl", mavl);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertProduct(Product product)
        {
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "insert into VATLIEU ( TENVATLIEU, DONGIA, SOLUONG, LOAIVATLIEU, DONVITINH)values(@tenvl, @dongia, @soluong,@loaivl, @donvitinh)";
                using(cmd = new SqlCommand(sql, conn))
                {
                  
                    cmd.Parameters.AddWithValue("@tenvl", product.NameProduct);
                    cmd.Parameters.AddWithValue("@dongia", product.PriceProduct);
                    cmd.Parameters.AddWithValue("@soluong", product.Quantity);
                    cmd.Parameters.AddWithValue("@loaivl", product.IdCategory);
                    cmd.Parameters.AddWithValue("@donvitinh", product.DonViTinh);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Product getProductById(int id)
        {
            Product product = new Product();
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from vatlieu where mavatlieu = @mavatlieu";
                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@mavatlieu", id);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int maVL = Convert.ToInt32(reader.GetInt32(0));
                        string tenVL = reader.GetString(1);
                        double giaVL = Convert.ToInt32(reader.GetInt32(2));
                        int soluong = Convert.ToInt32(reader.GetInt32(3));
                        string loaiVL = reader.GetString(4);
                        string donvitinh = reader.GetString(5);
                         product = new Product(maVL, tenVL, giaVL, soluong, loaiVL, donvitinh);
                        

                    }
                }
            }
            return product;
        }

        public List<Product> FindNameInInvoice(string TenLoaiVL)
        {
            List<Product> list = new List<Product>();
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string connectionStr = "select mavatlieu,tenvatlieu from VATLIEU where TENVATLIEU like @TENVATLIEU ";
                using (cmd = new SqlCommand(connectionStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TENVATLIEU", "%" + TenLoaiVL + "%");
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int maVL = Convert.ToInt32(reader.GetInt32(0));
                            string tenVL = reader.GetString(1);
                            Product product = new Product(maVL, tenVL, 0,0,"","");
                            list.Add(product);
                        }
                    }
                    return list;

                }

            }
        }
    }


}


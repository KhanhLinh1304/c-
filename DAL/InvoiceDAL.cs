using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InvoiceDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;


        public void CreateInvoices(Invoice invoice, List<MyItem> items)
        {
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "insert into hoadon(mahoadon, tongtien, created_time, makhachhang, manhanvien) values(@maHD,@tongtien,@time,@makh,@maNV)";
                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", invoice.IdInvoice);
                    cmd.Parameters.AddWithValue("@tongtien", invoice.TotalPrice);
                    cmd.Parameters.AddWithValue("@time", invoice.createdDate);
                    cmd.Parameters.AddWithValue("@maKH", invoice.IdCustomer);
                    cmd.Parameters.AddWithValue("@maNV", invoice.IdEmployee);
                    int row = cmd.ExecuteNonQuery();
                    if(row > 0)
                    {
                        Console.WriteLine("thành công");
                    }
                    else
                    {
                        Console.WriteLine("thất bại");
                    }
                }


                string getInvoiceIdSql = "SELECT TOP 1 mahoadon AS LastID FROM hoadon ORDER BY created_time desc";
                string invoiceId;
                using (cmd = new SqlCommand(getInvoiceIdSql, conn))
                {
                    invoiceId = cmd.ExecuteScalar().ToString();
                }

                foreach (var item in items)
                {
                    string sqlDetail = "insert into chitiet_hoadon(soluong,tongtien,mahoadon,mavatlieu) values(@slDetail, @ttDetail, @maHoaDon, @maVatLieu) ";
                    using(cmd = new SqlCommand(sqlDetail, conn))
                    {
                        cmd.Parameters.AddWithValue("@slDetail", item.QuantityItem);
                        cmd.Parameters.AddWithValue("@ttDetail", item.PriceItem);
                        cmd.Parameters.AddWithValue("@maHoaDon", invoiceId);
                        cmd.Parameters.AddWithValue("@mavatlieu", item.IdItem);
                        cmd.ExecuteNonQuery();
                    }
                    string sqlUpdate = "update vatlieu set soluong = soluong - @sl where mavatlieu = @mavl";
                    using(cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@sl",item.QuantityItem);
                        cmd.Parameters.AddWithValue("@mavl", item.IdItem);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from KHACHHANG where MAKH = @maKH";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maKH", id);
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idC = Convert.ToInt32(reader.GetInt32(0));
                            string name = reader.GetString(1);
                            string phone = reader.GetString(2);
                            string addr = reader.GetString(3);
                            customer = new Customer(idC, name, phone, addr);
                        }
                    }
                    
                }
            }
            return customer;
        }
        public List<Invoice>GetInvoiceByIdUser(int id) { 
            List<Invoice> list = new List<Invoice>();
            
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select hd.*, nv.tennv from hoadon hd inner join nhanvien nv on hd.manhanvien = nv.manv where makhachhang = @maKH";
                using(cmd= new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maKH", id);
                    using(reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mahoadon = reader.GetString(0);
                            int tongtien = Convert.ToInt32(reader.GetInt32(1));
                            int maKH = Convert.ToInt32(reader.GetInt32(2));
                            int maNV = Convert.ToInt32(reader.GetInt32(3));
                            DateTime date = Convert.ToDateTime(reader.GetDateTime(4));
                            string tenNV = reader.GetString(5);
                            Invoice invoice = new Invoice(mahoadon,maKH,tongtien,date,maNV);
                            invoice.EmployeeName = tenNV;
                            list.Add(invoice);
                        }
                    }
                }
                return list;

            }
         
        }

        public List<MyItem> GetItemByIdInvoice(string maHD)
        {
            List<MyItem > list = new List<MyItem>();
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select i.*, v.tenvatlieu,v.donvitinh from chitiet_hoadon i inner join vatlieu v on i.mavatlieu = v.mavatlieu where mahoadon = @mahoadon";
                using(cmd = new SqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@mahoadon", maHD);
                    using(reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string donvitinh = reader.GetString(6);
                            int idItem = Convert.ToInt32(reader.GetInt32(4));
                            int quantityItem = Convert.ToInt32(reader.GetInt32(1));
                            int priceItem = Convert.ToInt32(reader.GetInt32(2));
                         //   string mahoafon = reader.GetString(3);
                            string tenvatlieu = reader.GetString(5);
                            MyItem item = new MyItem(donvitinh,tenvatlieu,0,idItem,quantityItem,priceItem);
                            list.Add(item);
                        }
                    }
                  
                }
                return list;
            }
        }
        /*public List<MyItem> GetObject(string madonhang)
        {
            List<MyItem> items = new List<MyItem>();
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select item.*, v.donvitinh,v.tenvatlieu,v.dongia" +
                    "from chitiet_hoadon item inner join vatlieu v on item.mavatlieu=v.mavatlieu" +
                    "where mahoadon = @maHD";
                using(cmd = new SqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", madonhang);
                    using(reader = cmd.ExecuteReader()) {
                        while (reader.Read())
                        {
                            int idItem = Convert.ToInt32(reader.GetInt32(1));
                            int quantityItem = Convert.ToInt32(reader.GetInt32(2));
                            int priceItem = Convert.ToInt32(reader.GetInt32(3));
                            string donvitinh = reader.GetString(5);
                            string tenvatlieu = reader.GetString(6);
                            int dongia = Convert.ToInt32(reader.GetInt32(7));
                            MyItem item = new MyItem(donvitinh, tenvatlieu, dongia, idItem, quantityItem, priceItem);
                            items.Add(item);
                        }
                    }
                   
                   
                }
                 
            }
            return items;
        }*/
        /*public List<MyItem> GetObject(string madonhang)
        {
            List<MyItem> items = new List<MyItem>();

            using (conn = ConnectDB.connection())
            {
                conn.Open();

                string sql = "select item.*, v.donvitinh,v.tenvatlieu,v.dongia from chitiet_hoadon item inner join vatlieu v on item.mavatlieu=v.mavatlieu where mahoadon = @maHoaDon";

                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maHoaDon", madonhang);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int idItem = Convert.ToInt32(reader.GetInt32(1));
                        int quantityItem = Convert.ToInt32(reader.GetInt32(2));
                        int priceItem = Convert.ToInt32(reader.GetInt32(3));
                        string donvitinh = reader.GetString(5);
                        string tenvatlieu = reader.GetString(6);
                        int dongia = Convert.ToInt32(reader.GetInt32(7));

                        MyItem item = new MyItem(donvitinh, tenvatlieu, dongia, idItem, quantityItem, priceItem);
                        items.Add(item);
                    }
                }
            }

            return items;
        }*/
       
    }
   

}

using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public Boolean CheckExistCustomerById(int id)
        {
            bool check = false;
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from Customer where makh = @makh";
                using(cmd= new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@makh", id);
                    using(reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idkh = Convert.ToInt32(reader.GetInt32(0));
                            string name = reader.GetString(1);
                            string sdt = reader.GetString(3);
                            string diachi = (reader.GetString(2));
                            Customer customer = new Customer(idkh, name, sdt, diachi);
                            check = true;
                        }
                    }
                }
                return check;
            }
        }
        public List<Customer> getListCustomer()
        {
            List<Customer> list = new List<Customer>();
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from KHACHHANG order by MAKH desc";
                using(cmd = new SqlCommand(sql, conn))
                {
                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        int id = Convert.ToInt32(reader.GetInt32(0));
                        string name = reader.GetString(1);
                        string sdt = reader.GetString(3);
                        string diachi = (reader.GetString(2));
                        Customer customer = new Customer(id,name,sdt,diachi);
                        list.Add(customer);
                    }
                }
            }
            return list;
        }
        public void InsertCustomer(Customer customer)
        {
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "insert into KHACHHANG(TENKH,SDTKH,DIACHI) values(@ten,@sdt, @diachi)";
                using(cmd = new SqlCommand (sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", customer.NameCustomer);
                    cmd.Parameters.AddWithValue("@sdt", customer.PhoneCustomer);
                    cmd.Parameters.AddWithValue("@diachi", customer.AddressCustomer);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "update KHACHHANG set TENKH = @ten, SDTKH = @sdt, DIACHI = @diachi where MAKH = @makh";
                using(cmd = new SqlCommand (sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ten", customer.NameCustomer);
                    cmd.Parameters.AddWithValue("@sdt", customer.PhoneCustomer);
                    cmd.Parameters.AddWithValue("@diachi", customer.AddressCustomer);
                    cmd.Parameters.AddWithValue("@makh", customer.IdCustomer);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteCustomer(int id)
        {
            using(conn = ConnectDB.connection ())
            {
                conn.Open();
                string sql = "delete from KHACHHANG where MAKH = @makh";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@makh", id);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public List<Customer> SearchCustomer(string sdtkh)
        {
            List<Customer> list = new List<Customer>();
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from KHACHHANG where SDTKH like @sdt";
                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sdt" , "%" + sdtkh + "%");
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader.GetInt32(0));
                        string name = reader.GetString(1);
                        string sdt = reader.GetString(3);
                        string diachi = (reader.GetString(2));
                        Customer customer = new Customer(id, name, sdt, diachi);
                        list.Add(customer);
                    }
                }
            }
            return list;
        }
        public Boolean CheckExistCustomerByPhone(string sdt)
        {
            bool check = false;
            Customer customer = null;
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "select * from KHACHHANG where SDTKH = @sdtkh";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@sdtkh", sdt);
                    using(reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader.GetInt32(0));
                            string name = reader.GetString(1);
                            string sdtkh = reader.GetString(3);
                            string diachi = (reader.GetString(2));
                            customer = new Customer(id, name, sdtkh, diachi);
                            if(customer != null)
                            {
                                check = true;
                            }  
                        }
                    }
                }
            }
            return check;
        }
    }
}

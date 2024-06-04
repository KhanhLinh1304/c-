using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public void insertCategory(Category category)
        {
            using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "insert into LOAIVATLIEU(MALOAIVATLIEU,TENLOAIVATLIEU) values(@maVL, @tenVL)";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maVL", category.IdCategory);
                    cmd.Parameters.AddWithValue("@tenVL", category.NameCategory);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void updateCategory(Category category)
        {
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "update LOAIVATLIEU SET TENLOAIVATLIEU = @tenVL where MALOAIVATLIEU = @maVL" ;
                using (cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maVL", category.IdCategory);
                    cmd.Parameters.AddWithValue("@tenVL", category.NameCategory);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteCategory(string id) {
             using(conn = ConnectDB.connection())
            {
                conn.Open();
                string sql = "delete from LOAIVATLIEU where MALOAIVATLIEU = @maVL";
                using(cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maVL", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Category> searchCategories(string nameCatecory)
        {
            using (conn = ConnectDB.connection())
            {
                conn.Open();
                List<Category> categories = new List<Category>();
                string connectionStr = "select * from LOAIVATLIEU where MALOAIVATLIEU like @maloaivl";

                using (cmd = new SqlCommand(connectionStr, conn))
                {
                    cmd.Parameters.AddWithValue("@maloaivl", "%" + nameCatecory + "%");
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maloaivl = reader.GetString(0);
                            string tenloaivl = reader.GetString(1);
                            Category category = new Category(maloaivl, tenloaivl);
                            categories.Add(category);
                        }

                    }
                }
                return categories;
            }

        }
        /* public List<Category> getAllCategories()
         {
             using(conn = ConnectDB.connection())
             {
                 conn.Open();
                 List<Category> categories = new List<Category>();   
                 string connectionStr = "select * from LOAIVATLIEU";
                 using(cmd = new SqlCommand(connectionStr, conn))
                 {
                     using(reader = cmd.ExecuteReader())
                     {
                         while(reader.Read()) {
                             string maloaivl = reader.GetString(0);
                             string tenloaivl = reader.GetString(1);
                             Category category = new Category(maloaivl, tenloaivl);
                             categories.Add(category);
                         }

                     }
                 }
                 return categories;
             }
         }*/
    }
}

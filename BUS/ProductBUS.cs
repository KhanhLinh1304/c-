using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBUS
    {
        private ProductDAL productDAL = new ProductDAL();
        public List<Product> getListProduct()
        {
            return productDAL.getListProduct();
        }
        public List<Product> FillterProductByIdLoaiVL(string maLoaiVL)
        {
            return productDAL.FillterProductByIdLoaiVL(maLoaiVL);
        }
        public List<Product> SearchByNameVL(string TenLoaiVL)
        {
            return productDAL.SearchByNameVL(TenLoaiVL);
        }
        public void UpdateQuantityProduct(int soluong, int mavl)
        {
             productDAL.UpdateQuantityProduct(soluong, mavl); 
        }
        public void InsertProduct(Product product)
        {
            productDAL.InsertProduct(product);
        }
        public Product getProductById(int id)
        {
            return productDAL.getProductById(id);
        }
        public List<Product> FindNameInInvoice(string TenLoaiVL)
        {
            return productDAL.FindNameInInvoice(TenLoaiVL);
        }


    }
}

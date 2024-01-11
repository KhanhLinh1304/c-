using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        public Product()
        {
        }

        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }
        public int Quantity { get; set; }
        public string IdCategory { get; set; }
        public string DonViTinh { get; set; }

        public Product(int idProduct, string nameProduct, double priceProduct, int quantity, string idCategory, string donViTinh)
        {
            IdProduct = idProduct;
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
            Quantity = quantity;
            IdCategory = idCategory;
            DonViTinh = donViTinh;
        }
    }
}

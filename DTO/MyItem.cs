using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MyItem
    {
        public string DonViTinh {  get; set; }
        public string TenVatLieu {  get; set; }
        public int DonGia {  get; set; }
        public int IdItem
        {
            get; set;
        }
        public int QuantityItem {  get; set; }
        public int PriceItem { get; set; }
        public MyItem(string donvitinh, string tenvl, int dongia, int idVL, int quantity, int price)
        {
            this.DonViTinh = donvitinh;
            this.TenVatLieu = tenvl;
            this.DonGia = dongia;
            this.IdItem = idVL;
            this.QuantityItem = quantity;
            this.PriceItem = price;
        }

       
    }
}

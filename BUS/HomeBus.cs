using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HomeBus
    {
         HomeDAL homeDAL = new HomeDAL();
     
        public List<Product> getAllProducts()
        {
            return homeDAL.getAllProducts();
        }
        public List<MyItem> GetObject(string madonhang)
        {
            return homeDAL.GetObject(madonhang);
        }
    }
}

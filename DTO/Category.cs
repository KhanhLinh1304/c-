using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category
    {
        public Category() { }
        public string IdCategory { get; set; }
        public string NameCategory { get; set; }

        public Category(string idCategory, string nameCategory)
        {
            IdCategory = idCategory;
            NameCategory = nameCategory;
        }
    }

}


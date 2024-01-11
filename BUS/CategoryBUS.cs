using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryBUS
    {
        private CategoryDAL categoryDAL = new CategoryDAL();
        public void insertCategory(Category category)
        {
            categoryDAL.insertCategory(category);
        }
        public void updateCategory(Category category)
        {
            categoryDAL.updateCategory(category);
        }
        public void deleteCategory(string id)
        {
            categoryDAL.deleteCategory(id);
        }
        public List<Category> searchCategories(string nameCatecory)
        {
            List<Category> list = categoryDAL.searchCategories(nameCatecory);
            return list;
        }
    }
}

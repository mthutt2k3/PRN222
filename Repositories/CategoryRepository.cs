using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories() => CategoriesDAO.GetCategories();

        public Category GetCategoryById(short? id) => CategoriesDAO.GetCategoryById(id);

        public void SaveCategory(Category category) => CategoriesDAO.SaveCategory(category);

        public void UpdateCategory(Category category) => CategoriesDAO.UpdateCategory(category);

        public void DeleteCategory(Category category) => CategoriesDAO.DeleteCategory(category);

    }
}

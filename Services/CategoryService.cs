using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

        public Category GetCategoryById(short? id) => categoryRepository.GetCategoryById(id);

        public void SaveCategory(Category category) => categoryRepository.SaveCategory(category);

        public void UpdateCategory(Category category) => categoryRepository.UpdateCategory(category);

        public void DeleteCategory(Category category) => categoryRepository.DeleteCategory(category);
    }
}

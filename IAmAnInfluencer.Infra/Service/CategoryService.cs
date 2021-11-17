using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }

        public bool addCategory(Category category)
        {
            return categoryRepository.addCategory(category);
        }

        public bool deleteCategory(int ID)
        {
            return categoryRepository.deleteCategory(ID);
        }

        public List<Category> getAllCategory()
        {
            return categoryRepository.getAllCategory();
        }

        public bool updateCategory(Category category)
        {
            return categoryRepository.updateCategory(category);
        }
    }
}

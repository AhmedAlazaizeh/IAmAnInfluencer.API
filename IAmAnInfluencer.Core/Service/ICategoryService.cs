using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface ICategoryService
    {
        public bool addCategory(Category category);
        public List<Category> getAllCategory();
        public bool deleteCategory(int ID);
        public bool updateCategory(Category category);
    }
}

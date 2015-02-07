using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EShop.Models;

namespace EShop.Repository
{
    public interface ICategoriesRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int CatId);
        void AddCategory(Category category);
        void UpdateCategory(int id,Category category);
        void DeleteCategory(Category category);
       
        void Save();
    }
}
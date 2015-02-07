using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EShop.Models;
using EShop.Models;

namespace EShop.Repository.Categories
{
    public class CategoriesRepository :ICategoriesRepository,IDisposable
    {
        private EshopContext entities = null;
        public CategoriesRepository(EshopContext context)
        {
            this.entities = context;
        }
        public List<Models.Category>  GetAllCategories()
        {
 	       return entities.Categories.ToList();
        }

        public Category  GetCategoryById(int CatId)
        {
 	        return entities.Categories.SingleOrDefault(Category => Category.CatId==CatId);
        }

        public void  AddCategory(Category category)
        {
            entities.Categories.Add(category);
        }

        public void  UpdateCategory(int id,Category category)
        {
            Category cat = GetCategoryById(id);
            cat = category;
 	    }

        public void  DeleteCategory(Category category)
        {
            entities.Categories.Remove(category);
        }

        public void  Save()
        {
            entities.SaveChanges();
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
        
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                entities = null;
            }
        }

        ~CategoriesRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}
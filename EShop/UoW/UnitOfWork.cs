using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EShop.Models;
using EShop.Repository;
using EShop.Repository.Categories;
namespace EShop.UoW
{
    public class UnitOfWork:IDisposable
    {
        private EshopContext entities = null;
        public UnitOfWork() {
            entities = new EshopContext();
            CategoryRepository = new CategoriesRepository(entities);
        }
        public ICategoriesRepository CategoryRepository { get; private set; }

        // This will be created from test project and passed on to the
        // controllers parameterized constructors
        public UnitOfWork(ICategoriesRepository repository) {
            CategoryRepository = repository;
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

        ~UnitOfWork()
        {
            Dispose(false);
        }

        #endregion
    }
}
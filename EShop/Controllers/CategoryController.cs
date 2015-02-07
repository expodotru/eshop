using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Models;
using EShop.Repository;
using EShop.Repository.Categories;
using EShop.UoW;
namespace EShop.Controllers
{
    public class CategoryController : Controller
    {
        private UnitOfWork UoW = null;
        public CategoryController()
            : this(new UnitOfWork())
        {
        }
        public CategoryController(UnitOfWork unitOfWork) {
            this.UoW = unitOfWork;
        }
        //
        // GET: /Category/

        public ActionResult Index()
        {
            return View(this.UoW.CategoryRepository.GetAllCategories());
        }

        //
        // GET: /Category/Details/5

        public ActionResult Details(int id = 0)
        {
            Category category = this.UoW.CategoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Category/Create

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                this.UoW.CategoryRepository.AddCategory(category);
                this.UoW.CategoryRepository.Save();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        //
        // GET: /Category/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Category category = this.UoW.CategoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                this.UoW.CategoryRepository.UpdateCategory(category.CatId, category);
                this.UoW.CategoryRepository.Save();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //
        // GET: /Category/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Category category = this.UoW.CategoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        //
        // POST: /Category/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = this.UoW.CategoryRepository.GetCategoryById(id);
            this.UoW.CategoryRepository.DeleteCategory(category);
            this.UoW.CategoryRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
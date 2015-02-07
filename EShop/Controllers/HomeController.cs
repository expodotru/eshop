﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //get list of categories
            List <Category> Categories= null;
            using (EshopContext context = new EshopContext()) {
                Categories = context.Categories.ToList();
            }
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(Categories);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

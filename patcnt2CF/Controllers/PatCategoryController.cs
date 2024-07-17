using patcntt2CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace patcntt2CF.Controllers
{
    public class PatCategoryController : Controller
    {
        private static PatBookStore _PatBookStore;
        public PatCategoryController()
        {
            _PatBookStore = new PatBookStore();
        }
        // GET: PatCategory
        public ActionResult PatIndex()
        {
            var PatCategory = _PatBookStore.PatCategories.ToList();
            return View(PatCategory);
 
        }
        [HttpGet]
        public ActionResult PatCreate()
        {
            
            var PatCategory = new PatCategory();
            return View(PatCategory);
            
        }
        [HttpPost]
        public ActionResult PatCreate(PatCategory PatCategory)
        {

            _PatBookStore.PatCategories.Add(PatCategory);
            _PatBookStore.SaveChanges();
            return RedirectToAction("PatIndex");

        }
    }
}
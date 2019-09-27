using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForumWeb.Models;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumDataAccess;
using System.Runtime.CompilerServices;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;

namespace ForumWeb.Controllers
{
    public class CategoryController : Controller
    {
        private IThreadService _threadService;
        private ICategoryService _categoryService;
        public CategoryController(IThreadService threadService, ICategoryService categoryService)
        {
            _threadService = threadService;
            _categoryService = categoryService;
        }
        public ActionResult Index(int id)
        {
            var category = _categoryService.GetAllCategories();  
            return View(category);
        }
        public IActionResult Category(int id)
        {
            var category = _categoryService.GetCategoryById(id);
 
            return View(category);
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel model)
        {
            _categoryService.CreateCategory(model);
            return RedirectToAction("Index", "Category");
        }
    }
}

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
    public class HomeController : Controller
    {
        private IThreadService _threadService;
        private IUserService _userService;
        private ICategoryService _categoryService;
        public HomeController(IThreadService threadService, IUserService userService, ICategoryService categoryService)
        {
            _threadService = threadService;
            _userService = userService;
            _categoryService = categoryService;
        }
        public ActionResult Index(int id)
        {
            var category = _categoryService.GetAllCategories();  
            return View(category);
        }
        public IActionResult Details(int id)
        {
            var category = _categoryService.GetCategoryById(id);
 
            return View(category);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ThreadViewModel model)
        {
            _threadService.CreateThread(model);
            return RedirectToAction("Index", "Home");
        }
    }
}

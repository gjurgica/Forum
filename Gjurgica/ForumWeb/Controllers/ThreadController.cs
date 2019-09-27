using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using ForumWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    public class ThreadController : Controller
    {
        private IThreadService _threadService;
        private ICategoryService _categoryService;
        public ThreadController(IThreadService threadService, ICategoryService categoryService)
        {
            _threadService = threadService;
            _categoryService = categoryService;

        }
        public IActionResult Thread(int id)
        {
            var thread =  _threadService.GetThreadById(id);
            return View(thread);
        }
        public IActionResult AddThread(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            ViewBag.Id = category.Id.ToString();
            ViewBag.title = category.Title;
            return View(new ThreadViewModel());
        }
        [HttpPost]
        public IActionResult AddThread(ThreadViewModel thread,string id)
        {
            var category = _categoryService.GetCategoryById(int.Parse(id));
            thread.Category = category;
            _threadService.CreateThread(thread);
            return RedirectToAction("Category", "Category",  new { category.Id });

        }
    }
}
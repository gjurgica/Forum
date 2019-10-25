using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebApp.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IThreadService _threadService;

        public CategoryController(ICategoryService categoryService, IThreadService threadService)
        {
            _categoryService = categoryService;
            _threadService = threadService;
        }

        [AllowAnonymous]
        public IActionResult ShowAllCategories()
        {

            var categories = _categoryService.GetAllCategories().ToList();
            
            return View(categories);
        }

        [Authorize(Roles = "admin")]
        public IActionResult CreateCategory(string title)
        {
            CategoryViewModel category = new CategoryViewModel();
            category.Title = title;
            category.Id = Guid.NewGuid().ToString();

            _categoryService.CreateCategory(category);

            return RedirectToAction("ShowAllCategories");
        }

        [Authorize(Roles = "admin")]
        public IActionResult DeleteCategory(string id)
        {
            _categoryService.DeleteCategory(id);

            return RedirectToAction("ShowAllCategories");
        }

        [Authorize(Roles = "admin")]
        public IActionResult EditCategory(string categoryId, string title)
        {
            _categoryService.UpdateCategory(categoryId, title);

            return RedirectToAction("ShowAllCategories");
        }

        [Authorize(Roles = "admin")]
        public IActionResult AddThread(string categoryId, string title)
        {
            ThreadViewModel thread = new ThreadViewModel();
            thread.Id = Guid.NewGuid().ToString();
            thread.Title = title;
            thread.CategoryId = categoryId;
            thread.DateCreated = DateTime.Now;

            _threadService.CreateThread(thread);

            return RedirectToAction("ShowAllCategories");
        }

        [Authorize(Roles = "admin")]
        public IActionResult EditThread(string threadId, string title)
        {
            ThreadViewModel thread = _threadService.GetThreadById(threadId);
            thread.Title = title;

            _threadService.UpdateThread(thread);

            return RedirectToAction("ShowAllCategories");
        }

        [Authorize(Roles = "admin")]
        public IActionResult RemoveThread(string threadId)
        {
            _threadService.DeleteThread(threadId);

            return RedirectToAction("ShowAllCategories");
        }

        [AllowAnonymous]
        public IActionResult ShowThread(string id)
        {
            return RedirectToAction("ShowPosts", "Post", new { threadId = id });
        }
    }
}
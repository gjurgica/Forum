using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebApp.Controllers
{
    [Authorize]
    public class ThreadController : Controller
    {
        private readonly IThreadService _threadService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public ThreadController(IThreadService threadService, ICategoryService categoryService, IUserService userService)
        {
            _threadService = threadService;
            _categoryService = categoryService;
            _userService = userService;
        }

        [AllowAnonymous]
        public IActionResult ShowAllThreads(string categoryId, string categoryTitle)
        {
            ViewData["CategoryTitle"] = categoryTitle;
            ViewData["CategoryId"] = categoryId;
            ViewData["Users"] = _userService.GetAllUsers();

            var thread = _threadService.GetAllThreads().Where(t => t.CategoryId == categoryId).ToList();

            return View(thread);
        }

        public IActionResult AddThread2(string categoryId, string title)
        {
            ThreadViewModel thread = new ThreadViewModel();
            thread.Id = Guid.NewGuid().ToString();
            thread.Title = title;
            thread.CategoryId = categoryId;
            thread.DateCreated = DateTime.Now;

            _threadService.CreateThread(thread);

            return RedirectToAction("ShowAllThreads", new { categoryId, categoryTitle = title});
        }

        [Authorize(Roles = "admin")]
        public IActionResult EditThread2(string threadId, string title)
        {
            ThreadViewModel thread = _threadService.GetThreadById(threadId);
            thread.Title = title;

            string categoryTitle = _categoryService.GetCategoryById(thread.CategoryId).Title;

            _threadService.UpdateThread(thread);

            return RedirectToAction("ShowAllThreads", new { categoryId = thread.CategoryId, categoryTitle});
        }

        [Authorize(Roles = "admin")]
        public IActionResult RemoveThread2(string threadId)
        {
            ThreadViewModel thread = _threadService.GetThreadById(threadId);

            string categoryTitle = _categoryService.GetCategoryById(thread.CategoryId).Title;

            _threadService.DeleteThread(threadId);

            return RedirectToAction("ShowAllThreads", new { categoryId = thread.CategoryId, categoryTitle });
        }
    }
}
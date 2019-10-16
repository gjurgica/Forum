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
        private readonly IThreadService _threadService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        public ThreadController(IThreadService threadService, ICategoryService categoryService, IUserService userService,IPostService postService)
        {
            _threadService = threadService;
            _categoryService = categoryService;
            _userService = userService;
            _postService = postService;

        }
        public IActionResult Thread(int id,int currentpage)
        {
            var thread =  _threadService.GetThreadById(id);
            thread.Posts = thread.Posts.OrderByDescending(x => x.Created);
            var model = new PaginationModel()
            {
                Data = _postService.GetPaginatedResult(thread.Posts.ToList(), currentpage),
                Count = thread.Posts.Count()
            };
            ViewBag.thread = thread;
            if (User.Identity.IsAuthenticated)
            {
                var user = _userService.GetCurrentUser(User.Identity.Name);
                ViewBag.user = user;
                return View(model);
            }
            return View(model);
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
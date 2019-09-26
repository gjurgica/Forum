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
    public class PostController : Controller
    {
        private IPostService _postService;
        private IUserService _userService;
        private IThreadService _threadService;
        public PostController(IPostService postService,IUserService userService,IThreadService threadService)
        {
            _postService = postService;
            _userService = userService;
            _threadService = threadService;

        }
        public IActionResult Index(int id)
        {
            var thread =  _threadService.GetThreadById(id);
            return View(thread);
        }
        public IActionResult Add(int id)
        {
            var thread = _threadService.GetThreadById(id);
            ViewBag.Id = thread.Id.ToString();
            ViewBag.title = thread.Title;
            return View(new PostViewModel());
        }
        [HttpPost]
        public IActionResult Add(PostViewModel post,string id)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            var thread = _threadService.GetThreadById(int.Parse(id));
            post.User = user;
            post.Thread = thread;
            _postService.CreatePost(post);
            return RedirectToAction("Details", "Home",  new { thread.Id });

        }
    }
}
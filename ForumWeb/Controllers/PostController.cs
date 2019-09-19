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
        public PostController(IPostService postService)
        {
            _postService = postService;

        }
        public IActionResult Index(int id)
        {
            var post =  _postService.GetPostById(id);
            return View(post);
        }
        public IActionResult Add(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(PostViewModel post)
        {
             _postService.CreatePost(post);
            return RedirectToAction("Details", "Home", new { id = post.Id });

        }
    }
}
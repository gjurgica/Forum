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
        private IForumService _forumService;
        public PostController(IPostService postService,IUserService userService,IForumService forumService)
        {
            _postService = postService;
            _userService = userService;
            _forumService = forumService;

        }
        public IActionResult Index(int id)
        {
            var post =  _postService.GetPostById(id);
            return View(post);
        }
        public IActionResult Add(int id)
        {
            var forum = _forumService.GetForumById(id);
            ViewBag.Id = forum.Id.ToString();
            ViewBag.title = forum.Title;
            return View(new PostViewModel());
        }
        [HttpPost]
        public IActionResult Add(PostViewModel post,string id)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            var forum = _forumService.GetForumById(int.Parse(id));
            post.User = user;
            post.Forum = forum;
            _postService.CreatePost(post);
            return RedirectToAction("Details", "Home",  new { forum.Id });

        }
    }
}
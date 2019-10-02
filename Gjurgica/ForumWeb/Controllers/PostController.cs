﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;


namespace ForumWeb.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        private readonly IThreadService _threadService;
        public PostController(IPostService postService,IUserService userService, IThreadService threadService)
        {
            _postService = postService;
            _userService = userService;
            _threadService = threadService;
        }
        public IActionResult GetPost()
        {
            return View();
        }
        public IActionResult CreatePost(int id)
        {
            var thread = _threadService.GetThreadById(id);
            ViewBag.Id = thread.Id.ToString();
            ViewBag.title = thread.Title;
            return View(new PostViewModel());
        }
        [HttpPost]
        public IActionResult CreatePost(PostViewModel post,string id)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            var thread = _threadService.GetThreadById(int.Parse(id));
            post.User = user;
            post.Thread = thread;
            _postService.CreatePost(post);
            return RedirectToAction("Thread", "Thread", new { thread.Id });
        }
        public   IActionResult GetRecentPosts(int page=1)
        {
            var posts =   _postService.GetAllPosts().AsQueryable().AsNoTracking().OrderByDescending(x => x.Created);
            var pageingPosts = PagingList.Create(posts, 3, page);
            var user = _userService.GetCurrentUser(User.Identity.Name);
            ViewBag.user = user;
            return View(pageingPosts);
        }
    }
}
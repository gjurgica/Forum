using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IThreadService _threadService;
        private readonly IUserService _userService;
        private readonly IAlertService _alertService;

        public PostController(IPostService postService, IThreadService threadService, IUserService userService, IAlertService alertService)
        {
            _postService = postService;
            _threadService = threadService;
            _userService = userService;
            _alertService = alertService;
        }

        public IActionResult ShowPosts(string threadId, string page)
        {
            ViewData["ThreadTitle"] = _threadService.GetThreadById(threadId).Title;
            ViewData["ThreadId"] = threadId;
            ViewData["Users"] = _userService.GetAllUsers();
            ViewData["Alerts"] = _alertService.GetAllAlerts().ToList();

            List<PostViewModel> posts = _postService.GetAllPost().Where(p => p.ThreadId == threadId).OrderBy(p => p.DateCreated).ToList();

            if (page == null)
                page = "0";
            ViewBag.TotalCount = posts.Count();
            ViewBag.Page = int.Parse(page);
            ViewData["PostsCount"] = decimal.ToInt32(Math.Round(Math.Ceiling((decimal)posts.Count() / 5), 0));

            List<PostViewModel> sorted = Pagination(posts, int.Parse(page));

            return View(sorted);
        }

        [HttpPost]
        public IActionResult AddPost(string text, string threadId, string poster)
        {
            PostViewModel post = new PostViewModel();
            post.Id = Guid.NewGuid().ToString();
            post.DateCreated = DateTime.Now;
            post.Content = text;
            post.ThreadId = threadId;
            post.UserId = _userService.GetAllUsers().SingleOrDefault(u => u.Username == poster).Id;

            _postService.CreatePost(post);

            return RedirectToAction("ShowPosts", new { threadId });
        }

        [HttpPost]
        public IActionResult EditPost(string postId, string content, string threadId)
        {
            PostViewModel post = _postService.GetPostById(postId);
            post.Content = content;

            _postService.ChangePost(post);

            return RedirectToAction("ShowPosts", new { threadId });
        }

        public IActionResult DeletePost(string id, string threadId)
        {
            _postService.DeletePost(id);

            return RedirectToAction("ShowPosts", new { threadId});
        }

        public IActionResult DeletePost2(string id)
        {
            _postService.DeletePost(id);

            return RedirectToAction("RecentPosts");
        }

        public IActionResult DeletePost3(string id, string alertId)
        {
            _postService.DeletePost(id);
            _alertService.DeleteAlert(alertId);

            return RedirectToAction("ShowAlerts", "Alert");
        }

        [HttpPost]
        public IActionResult PostReply(string originalPost, string reply, string threadId, string poster)
        {
            string splitter = "e3f79af2";
            PostViewModel post = new PostViewModel();

            post.Id = Guid.NewGuid().ToString();
            post.DateCreated = DateTime.Now;
            post.ThreadId = threadId;
            post.UserId = _userService.GetCurrentUser(User.Identity.Name).Id;

            post.Content = "Posted by " + poster + ": " + splitter + " " + originalPost + " " + splitter + " Reply by " + User.Identity.Name + ": " + reply;

            _postService.CreatePost(post);

            return RedirectToAction("ShowPosts", new { threadId });
        }

        
        public IActionResult Search(string search, string page)
        {
            if (search != null)
            {
                ViewData["Users"] = _userService.GetAllUsers();
                ViewData["Threads"] = _threadService.GetAllThreads();
                ViewData["Alerts"] = _alertService.GetAllAlerts().ToList();

                List<PostViewModel> result = _postService.GetAllPost().Where(p => p.Content.Contains(search, StringComparison.OrdinalIgnoreCase)).OrderByDescending(p => p.DateCreated.Date).ThenByDescending(p => p.DateCreated.TimeOfDay).ToList();

                if (page == null)
                    page = "0";

                ViewBag.SearchTerm = search;
                ViewBag.Page = int.Parse(page);
                List<PostViewModel> sorted = Pagination(result, int.Parse(page));
                ViewBag.TotalCount = result.Count();
                ViewData["SearchResultCount"] = decimal.ToInt32(Math.Round(Math.Ceiling((decimal)result.Count() / 5), 0));


                return View(sorted);
            }

            return RedirectToAction("ShowAllCategories", "Category");
        }

        public IActionResult RecentPosts(string page)
        {
            ViewData["Users"] = _userService.GetAllUsers();
            ViewData["Threads"] = _threadService.GetAllThreads();
            ViewData["Alerts"] = _alertService.GetAllAlerts().ToList();

            List<PostViewModel> posts = _postService.GetAllPost().OrderByDescending(p => p.DateCreated.Date).ThenByDescending(p => p.DateCreated.TimeOfDay).ToList();
            ViewBag.TotalCount = posts.Count();
            ViewData["RecentPostsCount"] = decimal.ToInt32(Math.Round(Math.Ceiling((decimal)posts.Count()/5), 0));

            if (page == null)
                page = "0";

            ViewBag.Page = int.Parse(page);
            List<PostViewModel> sorted = Pagination(posts, int.Parse(page));

            return View(sorted);
        }

        private List<PostViewModel> Pagination(List<PostViewModel> posts, int page)
        {
            List<PostViewModel> sortedPosts = posts.Skip(page * 5)
                .Take(5)
                .ToList();

            return sortedPosts;
        }
    }
}
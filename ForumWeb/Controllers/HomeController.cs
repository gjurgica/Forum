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

namespace ForumWeb.Controllers
{
    public class HomeController : Controller
    {
        private IForumRepository _forumRepository;
        private IPostRepository _postRepository;
        private IUserRepository _userRepository;
        public HomeController(IForumRepository forumRepository,IPostRepository postRepository,IUserRepository userRepository)
        {
            _forumRepository = forumRepository;
            _postRepository = postRepository;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var takeFive = _forumRepository.GetAllForums().OrderBy(x => x.Created).Take(5);
            var forums = takeFive.Select(x => new ForumViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            });
            return View(forums);
        }
        public IActionResult Details(int id)
        {
            var forum = _forumRepository.GetForumById(id);
            var post = forum.Posts.OrderByDescending(p => p.Created).Take(5);
            var selected = post.Select(p => new PostViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                AuthorId = p.User.Id,
                AuthorName = p.User.FirstName,
                DatePosted = p.Created.ToString(),
                RepliesCount = p.Replies.Count(),
                Forum = BuildForumView(p)
            });
            var model = new TopicViewModel
            {
                Posts = selected,
                Forum = BuildForumView(forum)

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Search(int id)
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ForumViewModel forum)
        {
            User user = _userRepository.GetUserById(forum.AuthorId);
            Forum newForum = new Forum();
            newForum.Title = forum.Title;
            newForum.Description = forum.Description;
            newForum.ImageUrl = forum.ImageUrl;
            newForum.User = user;
            newForum.Created = DateTime.Now;
            _forumRepository.AddForum(newForum);
            return RedirectToAction("Index", "Home");
        }
        private ForumViewModel BuildForumView(Post post)
        {
            var forum = post.Forum;
            return BuildForumView(forum);
           
        }
        private ForumViewModel BuildForumView(Forum forum)
        {
            return new ForumViewModel
            {
                Id = forum.Id,
                Title = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
    }
}

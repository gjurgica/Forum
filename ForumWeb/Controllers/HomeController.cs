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
using System.Runtime.CompilerServices;

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
        public ActionResult Index(int id)
        {
            var takeFive = _forumRepository.GetAllForums().OrderByDescending(x => x.Created).Take(5);
            var user = _userRepository.GetUserById(id);
            var logged = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Url = user.Url
            };

            var forums = takeFive.Select(x => new ForumViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            });
            var model = new ForumUserViewModel
            {
                Forums = forums,
                User = logged
            };
            return View(model);
        }
        public IActionResult Details(int id,int userId)
        {
            var user = _userRepository.GetUserById(userId);
            var forum = _forumRepository.GetForumById(id);
            var post = forum.Posts.OrderByDescending(p => p.Created).Take(5);
            var selected = post.Select(p => new PostViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                //AuthorName = user.UserName,
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
        public IActionResult Add(int id)
        {
            var user = _userRepository.GetUserById(id);
            var model = new OneForumUserViewModel
            {
                User = new UserViewModel
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Url = user.Url
                }
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(OneForumUserViewModel model)
        {
            User user = _userRepository.GetUserById(model.User.Id);
            Forum newForum = new Forum();
            newForum.Title = model.Forum.Title;
            newForum.Description = model.Forum.Description;
            newForum.ImageUrl = model.Forum.ImageUrl;
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

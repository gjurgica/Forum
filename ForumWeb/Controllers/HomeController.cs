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
        public int loggedUserId = 0;
        public HomeController(IForumRepository forumRepository,IPostRepository postRepository,IUserRepository userRepository)
        {
            _forumRepository = forumRepository;
            _postRepository = postRepository;
            _userRepository = userRepository;
        }
        public ActionResult Index(int id)
        {
            var forums =  _forumRepository.GetAllForums()
                .Select(x => new ForumViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImageUrl = x.ImageUrl,
                    Created = DateTime.Now
                }
                ).OrderByDescending(x => x.Created).Take(5);
            return View(forums);
        }
        public async Task<IActionResult> Details(int id)
        {
            var forum = await _forumRepository.GetForumById(id);
            if(forum.Posts != null)
            {

            var post = forum.Posts.OrderByDescending(p => p.Created).Take(5);
            var selected = post.Select(p => new PostViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                AuthorId = 2,
               // AuthorName = p.User.UserName,
                DatePosted = p.Created.ToString(),
                RepliesCount = p.Replies.Count(),
                Forum = BuildForumView(p)
            });
            var model = new TopicViewModel
            {
                Posts = selected,
                Forum = BuildForumView(forum),
                UserId = loggedUserId

            };
            return View(model);
            }
            var model1 = new TopicViewModel()
            {
                Forum = BuildForumView(forum),
                UserId = loggedUserId
            };
            return View(model1);
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
        public async Task<IActionResult> Add(OneForumUserViewModel model)
        {
            User user = await _userRepository.GetUserById(model.User.Id);
            Forum newForum = new Forum();
            newForum.Title = model.Forum.Title;
            newForum.Description = model.Forum.Description;
            newForum.ImageUrl = model.Forum.ImageUrl;
            newForum.User = user;
            newForum.Created = DateTime.Now;
            await _forumRepository.AddForum(newForum);
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

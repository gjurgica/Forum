using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForumWeb.Models;
using ForumDataAccess.Interfaces;
using ForumDomain;

namespace ForumWeb.Controllers
{
    public class HomeController : Controller
    {
        private IForumRepository _forumRepository;
        private IPostRepository _postRepository;
        public HomeController(IForumRepository forumRepository,IPostRepository postRepository)
        {
            _forumRepository = forumRepository;
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            var forums = _forumRepository.GetAllForums().Select(x => new ForumViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            });
            return View(forums);
        }
        public IActionResult Details(int id)
        {
            var forum = _forumRepository.GetForumById(id);
            var post = forum.Posts;
            var selected = post.Select(p => new PostViewModel
            {
                Id = p.Id,
                Title = p.Title,
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

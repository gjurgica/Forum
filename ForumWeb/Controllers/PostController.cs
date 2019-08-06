using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository _postRepository;
        private IForumRepository _forumRepository;
        private IUserRepository  _userRepository;
        public PostController(IPostRepository postRepository,IForumRepository forumRepository,IUserRepository userRepository)
        {
            _postRepository = postRepository;
            _forumRepository = forumRepository;
            _userRepository = userRepository;
        }
        public IActionResult Index(int id)
        {
            var post = _postRepository.GetPostById(id);
            var replies = BuildPostReplies(post.Replies);
            var model = new PostViewModel();
            model.Id = post.Id;
            model.Title = post.Title;
            model.Content = post.Content;
            model.AuthorId = post.User.Id;
            model.AuthorName = post.User.UserName;
            model.AuthorImageUrl = post.User.Url;
            model.DatePosted = post.Created.ToString();
            model.RepliesCount = post.Replies.Count();
            model.Replies = replies;
            model.ForumId = post.Forum.Id;
            model.ForumTitle = post.Forum.Title;
            return View(model);
        }
        public IActionResult Add(int id)
        {
            Forum forum = _forumRepository.GetForumById(id);
            PostViewModel model = new PostViewModel();
            model.ForumId = forum.Id;
            model.ForumTitle = forum.Title;
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(PostViewModel viewPost)
        {
            var user = _userRepository.GetUserById(viewPost.AuthorId);
            var post = BuildPostReplies(viewPost,user);
             _postRepository.AddPost(post);
             return RedirectToAction("Details","Home",new {id = post.Id });
           
        }

        private Post BuildPostReplies(PostViewModel viewPost,User user)
        {
            var forum = _forumRepository.GetForumById(viewPost.ForumId);
            Post post = new Post();
            post.Title = viewPost.Title;
            post.Content = viewPost.Content;
            post.Created = DateTime.Now;
            post.ForumId = viewPost.ForumId;
            post.UserId = 2;
            post.User = user;
            post.Forum = forum;
            return post;
        }

        private IEnumerable<PostReplyViewModel> BuildPostReplies(List<PostReply> replies)
        {
            return replies.Select(r => new PostReplyViewModel
            {
                Id = r.Id,
                AuthorId = r.User.Id,
                AuthorName = r.User.UserName,
                AuthorImageUrl = r.User.Url,
                DatePosted = r.Created.ToString(),
                Content = r.Content
            });
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index(int id)
        {
            var post = _postRepository.GetPostById(id);
            var replies = BuildPostReplies(post.Replies);
            var model = new PostViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorImageUrl = post.User.Url,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Replies = replies
            };
            return View(model);
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
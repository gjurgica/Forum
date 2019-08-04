﻿using ForumDataAccess.Interfaces;
using ForumDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumDataAccess.Repositories
{
    public class PostRepository : IPostRepository
    {
        private ForumDbContext _context;
        public PostRepository(ForumDbContext context)
        {
            _context = context;
        }
        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }


        public void DeletePost(int id)
        {
            var deleted = _context.Posts.FirstOrDefault(x => x.Id == id);
            if(deleted != null)
            {
                _context.Posts.Remove(deleted);
                _context.SaveChanges();
            }
        }

        public void EditPost(Post post)
        {
            var edit = _context.Posts.FirstOrDefault(x => x.Id == post.Id);
            if(edit != null)
            {
                var index = _context.Posts.IndexOf(edit);
                _context.Posts.ToList()[index] = post;
                _context.SaveChanges();
            }
        }

        public List<Post> GetAllPosts()
        {
            return _context.Posts
                .Include(p => p.User)
                .Include(p => p.Replies)
                    .ThenInclude(r => r.User)
                .Include(p => p.Forum).
                ToList();
        }

        public Post GetPostById(int id)
        {
            return _context.Posts
                .Include(p => p.User)
                .Include(p => p.Replies)
                    .ThenInclude(r => r.User)
                .Include(p => p.Forum)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<Post> GetPostsByForum(int id)
        {
            return  _context.Forums.Where(f => f.Id == id).First().Posts;
        }
    }
}

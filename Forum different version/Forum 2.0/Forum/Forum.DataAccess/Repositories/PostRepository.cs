using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public class PostRepository : BaseRepository, IRepository<Post>
    {
        public PostRepository(ForumDbContext context) : base(context) { }

        public int Delete(string Id)
        {
            Post post = _context.Posts.FirstOrDefault(p => p.Id == Id);

            if (post == null)
            {
                return -1;
            }

            _context.Posts.Remove(post);

            return _context.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts;
        }

        public Post GetById(string Id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == Id);
        }

        public int Insert(Post entity)
        {
            _context.Posts.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Post entity)
        {
            Post post = _context.Posts.FirstOrDefault(p => p.Id == entity.Id);

            post.Content = entity.Content;

            return _context.SaveChanges();
        }
    }
}

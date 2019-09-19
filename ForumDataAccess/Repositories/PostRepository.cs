using ForumDataAccess.Interfaces;
using ForumDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumDataAccess.Repositories
{
    public class PostRepository : BaseRepository<ForumDbContext>, IPostRepository<Post>
    {
        public PostRepository(ForumDbContext context) : base(context) { }
        public int Delete(int id)
        {
            var post = _context.Posts.FirstOrDefault(x => x.Id == id);
            _context.Posts.Remove(post);
            return _context.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                .Include(x => x.User)
                .Include(x => x.Forum)
                .Include(x => x.Replies)
                    .ThenInclude(x => x.User);
        }

        public Post GetById(int id)
        {
            return _context.Posts
               .Include(x => x.User)
               .Include(x => x.Forum)
               .Include(x => x.Replies)
                   .ThenInclude(x => x.User)
               .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _context.Forums.Where(x => x.Id == id)
                .FirstOrDefault().Posts;
        }

        public int Insert(Post entity)
        {
            _context.Posts.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Post entity)
        {
            _context.Posts.Update(entity);
            return _context.SaveChanges();
        }
    }
}

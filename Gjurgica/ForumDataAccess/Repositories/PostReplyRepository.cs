using ForumDataAccess.Interfaces;
using ForumDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumDataAccess.Repositories
{
    public class PostReplyRepository : BaseRepository<ForumDbContext>, IRepository<PostReply>
    {
        public PostReplyRepository(ForumDbContext context) : base(context) { }

        public int Delete(int id)
        {
            var reply = _context.PostReplaies.FirstOrDefault(x => x.Id == id);
            _context.PostReplaies.Remove(reply);
            return _context.SaveChanges();
        }

        public IEnumerable<PostReply> GetAll()
        {
            return _context.PostReplaies
                .Include(x => x.User)
                .Include(x => x.Post)
                    .ThenInclude(x => x.User)
                .Include(x => x.Post)
                    .ThenInclude(x => x.Thread);
        }

        public PostReply GetById(int id)
        {
            return _context.PostReplaies
                .Include(x => x.User)
                .Include(x => x.Post)
                    .ThenInclude(x => x.User)
                .Include(x => x.Post)
                    .ThenInclude(x => x.Thread)
                .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(PostReply entity)
        {
            _context.PostReplaies.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(PostReply entity)
        {
            _context.PostReplaies.Update(entity);
            return _context.SaveChanges();
        }
    }
}

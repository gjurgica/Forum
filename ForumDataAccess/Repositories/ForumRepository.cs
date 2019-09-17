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
    public class ForumRepository : IForumRepository
    {
        private ForumDbContext _context;
        public ForumRepository(ForumDbContext context)
        {
            _context = context;
        }
        public void   AddForum(Forum forum)
        {
              _context.Forums.Add(forum);
              _context.SaveChanges();
        }

        public void DeleteForum(int id)
        {
            var deleted = _context.Forums.FirstOrDefault(x => x.Id == id);
            if(deleted != null)
            {
                _context.Forums.Remove(deleted);
                _context.SaveChanges();
            }
        }

        public void EditForum(Forum forum)
        {
            Forum edit = _context.Forums.FirstOrDefault(x => x.Id == forum.Id);
            if (edit != null)
            {
                int index = _context.Forums.IndexOf(edit);
                _context.Forums.ToList()[index] = forum;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Forum> GetAllForums()
        {
            return _context.Forums
                .Include(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(x => x.Replies)
                        .ThenInclude(x => x.User);
        }

        public Forum GetForumById(int id)
        {
            Forum forum = _context.Forums
                .Include(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(p => p.User)
                .Include(x => x.Posts)
                    .ThenInclude(p => p.Replies)
                        .ThenInclude(r => r.User)
                        .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);
           
            return forum;
        }
    }
}

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
        public async Task AddForum(Forum forum)
        {
              _context.Forums.Add(forum);
             await _context.SaveChangesAsync();
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

        public async  Task<Forum> GetForumById(int id)
        {
            Forum forum = await _context.Forums
                .Include(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(p => p.User)
                .Include(x => x.Posts)
                    .ThenInclude(p => p.Replies)
                        .ThenInclude(r => r.User)
                        .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
           
            return forum;
        }
    }
}

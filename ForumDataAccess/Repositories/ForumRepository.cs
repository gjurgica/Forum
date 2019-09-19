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
    public class ForumRepository : BaseRepository<ForumDbContext>,  IRepository<Forum>
    {
        public ForumRepository(ForumDbContext context) : base(context) { }

        public int Delete(int id)
        {
            var forum = _context.Forums.FirstOrDefault(x => x.Id == id);
            _context.Forums.Remove(forum);
            return _context.SaveChanges();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums
                .Include(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(x => x.Replies)
                        .ThenInclude(x => x.User);
        }

        public Forum GetById(int id)
        {
            return _context.Forums
               .Include(x => x.User)
               .Include(x => x.Posts)
                   .ThenInclude(x => x.User)
               .Include(x => x.Posts)
                   .ThenInclude(x => x.Replies)
                       .ThenInclude(x => x.User)
               .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Forum entity)
        {
            _context.Forums.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Forum entity)
        {
            _context.Forums.Update(entity);
            return _context.SaveChanges();
        }
    }
}

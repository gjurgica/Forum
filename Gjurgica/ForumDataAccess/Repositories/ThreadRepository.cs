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
    public class ThreadRepository : BaseRepository<ForumDbContext>,  IRepository<Thread>
    {
        public ThreadRepository(ForumDbContext context) : base(context) { }

        public int Delete(int id)
        {
            var thread = _context.Threads.FirstOrDefault(x => x.Id == id);
            _context.Threads.Remove(thread);
            return _context.SaveChanges();
        }

        public IEnumerable<Thread> GetAll()
        {
            return _context.Threads
                .Include(x => x.Posts)
                    .ThenInclude(x => x.User)
                .Include(x => x.Posts)
                    .ThenInclude(x => x.Replies)
                        .ThenInclude(x => x.User)
                 .Include(x => x.Category)
                .ToList();
        }

        public Thread GetById(int id)
        {
            return _context.Threads
               .Include(x => x.Posts)
                .ThenInclude(x => x.User)
                .Include(x => x.Category)
               .Include(x => x.Posts)
                   .ThenInclude(x => x.Replies)
                       .ThenInclude(x => x.User)
               .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Thread entity)
        {
            _context.Threads.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Thread entity)
        {
            _context.Threads.Update(entity);
            return _context.SaveChanges();
        }
    }
}

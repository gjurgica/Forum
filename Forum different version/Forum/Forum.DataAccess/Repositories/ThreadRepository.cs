using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public class ThreadRepository : BaseRepository, IRepository<Thread>
    {
        public ThreadRepository(ForumDbContext context) : base(context) { }
        public int Delete(string Id)
        {
            Thread thread = _context.Threads.FirstOrDefault(t => t.Id == Id);

            if (thread == null)
            {
                return -1;
            }

            _context.Threads.Remove(thread);
            return _context.SaveChanges();
        }

        public IEnumerable<Thread> GetAll()
        {
            return _context.Threads;
        }

        public Thread GetById(string Id)
        {
            return _context.Threads.FirstOrDefault(t => t.Id == Id);
        }

        public int Insert(Thread entity)
        {
            _context.Threads.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Thread entity)
        {
            Thread thread = _context.Threads.FirstOrDefault(t => t.Id == entity.Id);

            thread.Category = entity.Category;
            thread.Title = entity.Title;

            return _context.SaveChanges();
        }
    }
}

using ForumDataAccess.Interfaces;
using ForumDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumDataAccess.Repositories
{
    public class CategoryRepository : BaseRepository<ForumDbContext>, IRepository<Category>
    {
        public CategoryRepository(ForumDbContext context) : base(context) { }
        public int Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(category);
            return _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories
                .Include(x => x.Threads)
                    .ThenInclude(x => x.Posts)
                .ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories
                .Include(x => x.Threads)
                    .ThenInclude(x => x.Posts)
                .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Category entity)
        {
            _context.Categories.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Category entity)
        {
            _context.Categories.Update(entity);
            return _context.SaveChanges();
        }
    }
}

using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public class CategoryRepository : BaseRepository, IRepository<Category>
    {
        public CategoryRepository(ForumDbContext context) : base(context) { }
        public int Delete(string Id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == Id);

            if (category == null)
            {
                return -1;
            }

            _context.Remove(category);
            return _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.Include(c => c.Threads).ThenInclude(t => t.Posts);
        }

        public Category GetById(string Id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == Id);
        }

        public int Insert(Category entity)
        {
            _context.Categories.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Category entity)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == entity.Id);

            category.Title = entity.Title;

            return _context.SaveChanges();
        }
    }
}

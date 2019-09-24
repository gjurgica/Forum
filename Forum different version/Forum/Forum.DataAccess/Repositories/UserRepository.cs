using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository<User>
    {
        public UserRepository(ForumDbContext context) : base(context) { }

        public User GetById(string Id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == Id);
        }

        public User GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username);
        }

        public int Insert(User entity)
        {
            _context.Users.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(User entity)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == entity.Id);

            if (user == null)
            {
                return -1;
            }

            user.NormalizedEmail = entity.Email.ToUpper();
            user.Email = entity.Email;
            user.NormalizedUserName = entity.UserName.ToUpper();
            user.UserName = entity.UserName;

            return _context.SaveChanges();
        }

        public int Delete(string Id)
        {

            User user = _context.Users.FirstOrDefault(u => u.Id == Id);

            if (user == null)
            {
                return -1;
            }

            _context.Users.Remove(user);
            return _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}

using ForumDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ForumDataAccess
{
    public class UserRepository : IUserRepository
    {
        private ForumDbContext _context;
        public UserRepository(ForumDbContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}

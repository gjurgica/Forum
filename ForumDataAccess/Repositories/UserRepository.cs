using ForumDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ForumDataAccess
{
    public class UserRepository : IUserRepository
    {
        private ForumDbContext _context;
        public UserRepository(ForumDbContext context)
        {
            _context = context;
        }
        public async Task  AddUser(User user)
        {
             _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

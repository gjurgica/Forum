using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumDataAccess
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        Task<User> GetUserById(int id);
        Task AddUser(User user);
    }
}

using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
    }
}

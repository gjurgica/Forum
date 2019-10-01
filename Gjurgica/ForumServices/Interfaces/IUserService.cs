using ForumViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel);
        UserViewModel GetCurrentUser(string username);
        void Logout();
        UserViewModel GetUserById(string id);
        void UpdateUser(UserViewModel user);
    }
}

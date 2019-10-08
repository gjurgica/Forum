using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        string Login(LoginViewModel loginModel);
        void Logout();
        UserViewModel GetCurrentUser(string username);
        IEnumerable<UserViewModel> GetAllUsers();
        void UserOnlineStatus(string id, bool status);
        void UpdateUserInfo(string userId, string password, string email, string name, string surname);
        void UpdateAvatar(UserViewModel user);
        bool CheckPassword(string password, string userId);
        bool DeleteUser(string userId);
        void SuspendUser(string userId);
        void UnsuspendUser(string userId);
    }
}

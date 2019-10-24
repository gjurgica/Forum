using AutoMapper;
using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository<User> _userRepo;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserService(IUserRepository<User> userRepo,
                           UserManager<User> userManager,
                           SignInManager<User> signInManager,
                           IMapper mapper)
        {
            _userRepo = userRepo;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public void Register(RegisterViewModel registerModel, string role)
        {
            if (_userRepo.GetByUsername(registerModel.Username) != null)
                throw new Exception("Username already exists!");
            if (registerModel.Password != registerModel.ConfirmPassword)
                throw new Exception("Passwords does not match!");

            User user = _mapper.Map<User>(registerModel);
            user.Joined = DateTime.Now;
            user.Avatar = "/avatars/no-image.jpg";

            IdentityResult identityRes = _userManager
                .CreateAsync(user, registerModel.Password).Result;

            UserOnlineStatus(user.Id, true);

            if (identityRes.Succeeded)
            {
                User currentUser = _userManager
                    .FindByNameAsync(user.UserName).Result;

                var result = _userManager.AddToRoleAsync(currentUser, role).Result;

                if (result.Succeeded && role != "admin")
                {
                    Login(new LoginViewModel { Username = registerModel.Username, Password = registerModel.Password });
                    UserOnlineStatus(currentUser.Id, true);
                }
            }
            else
                throw new Exception(identityRes.Errors.ToString());
        }

        public string Login(LoginViewModel loginModel)
        {
            SignInResult signInRes = _signInManager.PasswordSignInAsync(
                loginModel.Username,
                loginModel.Password,
                false,
                false).Result;

            if (!signInRes.Succeeded)
            {
                return "Failed";
            }

            return "Succeeded";
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public UserViewModel GetCurrentUser(string username)
        {
            User user = _userRepo.GetByUsername(username);
            if (user == null)
                throw new Exception("User does not exist");

            return _mapper.Map<UserViewModel>(user);
        }

        public IEnumerable<UserViewModel> GetAllUsers()
        {
            return _mapper.Map<IEnumerable<UserViewModel>>(_userRepo.GetAll());
        }

        public void UserOnlineStatus(string id, bool status)
        {
            User user = _userRepo.GetById(id);
            user.IsItOnline = status;

            _userRepo.Update(user);
        }

        public void UpdateAvatar(UserViewModel user)
        {

            _userRepo.Update(_mapper.Map<User>(user));
        }

        public void UpdateUserInfo(string userId, string password, string email, string name, string surname)
        {
            User user = _userManager.FindByIdAsync(userId).Result;

            user.Email = email ?? user.Email;

            var fullName = user.FullName.Split(' ');
            string firstName = name ?? fullName[0];
            string lastName = surname ?? fullName[1];

            user.FullName = $"{firstName} {lastName}";

            if (password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(null, password);
            }

            _userRepo.Update(_mapper.Map<User>(user));
        }

        public bool CheckPassword(string password, string userId)
        {
            User user = _userManager.FindByIdAsync(userId).Result;
            bool checkPassword = _userManager.CheckPasswordAsync(user, password).Result;

            if (checkPassword)
            {
                return true;
            }

            return false;
        }

        public bool DeleteUser(string userId)
        {
            User user = _userManager.FindByIdAsync(userId).Result;

            var result = _userManager.DeleteAsync(user).Result;

            if (result.Succeeded)
            {
                return true;
            }

            return false;
        }

        public void SuspendUser(string userId)
        {
            User user = _userManager.FindByIdAsync(userId).Result;

            user.IsItSuspended = true;
            _userRepo.Update(user);
        }

        public void UnsuspendUser(string userId)
        {
            User user = _userManager.FindByIdAsync(userId).Result;

            user.IsItSuspended = false;
            _userRepo.Update(user);
        }
    }
}

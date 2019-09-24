using AutoMapper;
using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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

        public void Register(RegisterViewModel registerModel)
        {
            if (_userRepo.GetByUsername(registerModel.Username) != null)
                throw new Exception("Username already exists!");
            if (registerModel.Password != registerModel.ConfirmPassword)
                throw new Exception("Passwords does not match!");

            User user = _mapper.Map<User>(registerModel);
            user.Posts = new List<Post>();

            IdentityResult identityRes = _userManager
                .CreateAsync(user, registerModel.Password).Result;

            if (identityRes.Succeeded)
            {
                User currentUser = _userManager
                    .FindByNameAsync(user.UserName).Result;

                _userManager.AddToRoleAsync(currentUser, "user");
            }
            else
                throw new Exception(identityRes.Errors.ToString());

            Login(
                new LoginViewModel { Username = registerModel.Username, Password = registerModel.Password }
            );
        }

        public void Login(LoginViewModel loginModel)
        {
            SignInResult signInRes = _signInManager.PasswordSignInAsync(
                loginModel.Username,
                loginModel.Password,
                false,
                false).Result;

            if (signInRes.IsNotAllowed)
            {
                throw new Exception("Username or password is wrong!");
            }
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
    }
}

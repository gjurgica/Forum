using AutoMapper;
using ForumDataAccess;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository<User> _userService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserService(IUserRepository<User> userService, UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public UserViewModel GetCurrentUser(string username)
        {
            var user = _userService.GetByUsername(username);
            if (user == null)
            {
                throw new Exception("User does not exists!");
            }
            return _mapper.Map<UserViewModel>(user);
        }

        public UserViewModel GetUserById(string id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                throw new Exception("User does not exists!");
            }
            return _mapper.Map<UserViewModel>(user);
        }

        public void Login(LoginViewModel loginModel)
        {
            var result = _signInManager.PasswordSignInAsync(
                loginModel.UserName,
                loginModel.Password,
                false,
                false).Result;

            if (result.IsNotAllowed)
            {
                throw new Exception("Username or password is wrong!");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel registerModel)
        {
            if (_userService.GetByUsername(registerModel.UserName) != null)
                throw new Exception("Username already exists!");
            if (registerModel.Password != registerModel.ConfirmPassword)
                throw new Exception("Passwords does not match!");
            var user = _mapper.Map<User>(registerModel);
            var result = _userManager.CreateAsync(user, registerModel.Password).Result;

            if (result.Succeeded)
            {
                var currentUser = _userManager.FindByNameAsync(user.UserName).Result;
                _userManager.AddToRoleAsync(currentUser, "customer");
            }
            else
                throw new Exception(result.Errors.ToString());

            Login(new LoginViewModel
            {
                UserName = registerModel.UserName,
                Password = registerModel.Password
            });
        }
    }
}

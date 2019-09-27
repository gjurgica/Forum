using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using ForumWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
             _userService.Login(user);
            return RedirectToAction("Index", "Category");

        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(RegisterViewModel user)
        {
                _userService.Register(user);
                return Redirect("/Category/Index");
        }
        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "Category");
        }
        public IActionResult Profile(string username)
        {
            var user = _userService.GetCurrentUser(username);
            return View(user);
        }
    }
}
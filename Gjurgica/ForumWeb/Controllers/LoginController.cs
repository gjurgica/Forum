using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using ForumWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(LoginViewModel user)
        {
             _userService.Login(user);
            return RedirectToAction("Index", "Home");

        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(RegisterViewModel user)
        {
                _userService.Register(user);
                return Redirect("/Home/Index");
        }
        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }
    }
}
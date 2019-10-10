using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDomain;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;
using ForumWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IHostingEnvironment _hosting;
        public UsersController(IUserService userService, IHostingEnvironment hosting)
        {
            _userService = userService;
            _hosting = hosting;
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
            if (!ModelState.IsValid)
            {
                return View();
            }
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
            if (!ModelState.IsValid)
            {
                return View();
            }
                _userService.Register(user);
                return Redirect("/Category/Index");
        }
        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "Category");
        }
        [AllowAnonymous]
        public IActionResult Profile(string username)
        {
            var user = _userService.GetCurrentUser(username);
            return View(user);
        }
        [HttpPost]
        public IActionResult UploadPhoto(IFormFile photo)
        {
            if(photo != null)
            {
                var path = Path.Combine(_hosting.WebRootPath,Path.GetFileName(photo.FileName));
                photo.CopyTo(new FileStream(path, FileMode.Create));
                string image = "/" + Path.GetFileName(photo.FileName);
                var user = _userService.GetCurrentUser(User.Identity.Name);
                user.ImageUrl = image;
                _userService.UpdateUser(user);

            }
            return RedirectToAction("Profile", "Users" ,new {username = User.Identity.Name});
        }
    }
}
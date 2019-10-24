using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        private readonly IHostingEnvironment _hosting;
        private readonly IPrivateMessageService _messageService;
        private readonly IAlertService _alertService;

        public UserController(IUserService userService, IPostService postService, IHostingEnvironment hosting, IPrivateMessageService messageService, IAlertService alertService)
        {
            _userService = userService;
            _postService = postService;
            _hosting = hosting;
            _messageService = messageService;
            _alertService = alertService;
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegisterViewModel registration)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(registration, "user"); 
                return RedirectToAction("ShowAllCategories", "Category");
            }

            return RedirectToAction("registration", "user");
        }

        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAdmin(RegisterViewModel registration)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(registration, "admin");
                return RedirectToAction("ShowAllCategories", "Category");
            }

            return RedirectToAction("RegisterAdmin", "User");
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _userService.Login(model);
                if(result == "Succeeded")
                {
                    string userId = _userService.GetCurrentUser(model.Username).Id;
                    _userService.UserOnlineStatus(userId, true);
                    return RedirectToAction("ShowAllCategories", "Category");
                }
            }

            return RedirectToAction("login", "user");
        }

        public IActionResult LogOut()
        {
            string userId = _userService.GetCurrentUser(User.Identity.Name).Id;

            _userService.UserOnlineStatus(userId, false);
            _userService.Logout();
            return RedirectToAction("ShowAllCategories", "Category");
        }

        public IActionResult Members()
        {
            List<UserViewModel> members = _userService.GetAllUsers().ToList();

            return View(members);
        }

        public IActionResult Profile()
        {
            string userId = _userService.GetCurrentUser(User.Identity.Name).Id;

            ViewData["CountOfMessages"] = _postService.GetAllPost().Where(p => p.UserId == userId).Count();
            List<PrivateMessageViewModel> messages = _messageService.GetAllMessages()
                                                                    .Where(m => m.receiverId == userId)
                                                                    .OrderByDescending(pm => pm.Created.Date)
                                                                    .ThenByDescending(pm => pm.Created.TimeOfDay)
                                                                    .ToList();
            ViewBag.PrivateMessages = messages;
            ViewBag.Users = _userService.GetAllUsers().ToList();

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);

            return View(user);
        }

        [HttpPost]
        public IActionResult UploadPhoto(IFormFile photo)
        {
            if (photo != null)
            {
                var path = Path.Combine(_hosting.WebRootPath, @"avatars", Path.GetFileName(photo.FileName));
                photo.CopyTo(new FileStream(path, FileMode.Create));
                string image = "/avatars/" + Path.GetFileName(photo.FileName);
                var user = _userService.GetCurrentUser(User.Identity.Name);
                user.Avatar = image;
                _userService.UpdateAvatar(user);
            }
            return RedirectToAction("Profile");
        }

        [HttpPost]
        public IActionResult UpdateUser(string name,
                                        string surname,
                                        string email,
                                        string oldpassword,
                                        string newPassword,
                                        string confirmNewPassword)
        {
            
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);

            var fullName = user.FullName.Split(' ');
            string firstName = name ?? fullName[0];
            string lastName = surname ?? fullName[1];

            user.FullName = $"{firstName} {lastName}";
            user.Email = email ?? user.Email;

            if (oldpassword != null || newPassword != null || confirmNewPassword != null)
            {
                bool passwordCheck = _userService.CheckPassword(oldpassword, user.Id);

                if (passwordCheck && newPassword == confirmNewPassword)
                {
                    _userService.UpdateUserInfo(user.Id, newPassword, email, name, surname);
                    return RedirectToAction("Profile");
                }
                else
                {
                    return View("CustomErrorPage");
                }
            }

            _userService.UpdateUserInfo(user.Id, null, email, name, surname);
            return RedirectToAction("Profile");
        }

        public IActionResult DeleteUser(string userId)
        {
            bool result = _userService.DeleteUser(userId);

            if (result)
            {
                return View("Successfully");
            }

            return View("Failed");
        }

        public IActionResult DeleteUser2(string userId)
        {
            bool result = _userService.DeleteUser(userId);

            if (result)
            {
                return RedirectToAction("ShowAlerts", "Alert");
            }

            return View("Failed2");
        }

        public IActionResult Suspend(string userId)
        {
            _userService.SuspendUser(userId);

            return RedirectToAction("Members");
        }

        public IActionResult Suspend2(string userId, string alertId, string postId)
        {
            _userService.SuspendUser(userId);
            _alertService.DeleteAlert(alertId);
            _postService.DeletePost(postId);

            return RedirectToAction("ShowAlerts", "Alert");
        }

        public IActionResult Unsuspend(string userId)
        {
            _userService.UnsuspendUser(userId);

            return RedirectToAction("Members");
        }
    }
}
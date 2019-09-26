using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDomain;
using ForumServices.Interfaces;
using ForumWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    public class ProfileController : Controller
    {
        private IUserService _userService;
        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Details(string username)
        {
            var user =  _userService.GetCurrentUser(username);
            return View(user);
        }
    }
}
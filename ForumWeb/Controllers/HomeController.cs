using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForumWeb.Models;
using ForumDataAccess.Interfaces;
using ForumDomain;
using ForumDataAccess;
using System.Runtime.CompilerServices;
using ForumServices.Interfaces;
using ForumViewModels.ViewModels;

namespace ForumWeb.Controllers
{
    public class HomeController : Controller
    {
        private IForumService _forumService;
        private IUserService _userService;
        public HomeController(IForumService forumService,IUserService userService)
        {
            _forumService = forumService;
            _userService = userService;
        }
        public ActionResult Index(int id)
        {
            var forums = _forumService.GetAllForums();  
            return View(forums);
        }
        public IActionResult Details(int id)
        {
            var forum =  _forumService.GetForumById(id);
 
            return View(forum);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ForumViewModel model)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            model.User = user;
            _forumService.CreateForum(model);
            return RedirectToAction("Index", "Home");
        }
    }
}

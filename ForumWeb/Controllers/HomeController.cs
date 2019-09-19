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
        public HomeController(IForumService forumService)
        {
            _forumService = forumService;
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
        [HttpPost]
        public IActionResult Search(int id)
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ForumViewModel model)
        {
            _forumService.CreateForum(model);
            return RedirectToAction("Index", "Home");
        }
    }
}

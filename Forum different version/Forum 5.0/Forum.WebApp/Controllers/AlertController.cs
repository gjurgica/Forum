using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebApp.Controllers
{
    [Authorize]
    public class AlertController : Controller
    {
        private readonly IAlertService _alertService;
        private readonly IUserService _userService;
        private readonly IPostService _postService;

        public AlertController(IAlertService alertService, IUserService userService, IPostService postService)
        {
            _alertService = alertService;
            _userService = userService;
            _postService = postService;
        }

        [Authorize(Roles = "admin")]
        public IActionResult ShowAlerts()
        {
            List<AlertViewModel> alerts = _alertService.GetAllAlerts().ToList();
            ViewData["Users"] = _userService.GetAllUsers().ToList();
            ViewData["Posts"] = _postService.GetAllPost().ToList();

            return View(alerts);
        }

        public IActionResult CreateAlert(string userId, string postId, string threadId)
        {
            AlertViewModel alert = new AlertViewModel();
            alert.Id = Guid.NewGuid().ToString();
            alert.UserId = userId;
            alert.PostId = postId;

            _alertService.CreateAlert(alert);

            return RedirectToAction("ShowPosts", "Post", new { threadId });
        }

        public IActionResult CreateAlert2(string userId, string postId, string threadId)
        {
            AlertViewModel alert = new AlertViewModel();
            alert.Id = Guid.NewGuid().ToString();
            alert.UserId = userId;
            alert.PostId = postId;

            _alertService.CreateAlert(alert);

            return RedirectToAction("RecentPosts", "Post", new { threadId });
        }

        [Authorize(Roles = "admin")]
        public IActionResult RemoveAlert(string alertId)
        {
            _alertService.DeleteAlert(alertId);

            return RedirectToAction("ShowAlerts");
        }
    }
}
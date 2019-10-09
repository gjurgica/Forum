using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly IPrivateMessageService _messageService;
        private readonly IUserService _userService;

        public MessageController(IPrivateMessageService messageService, IUserService userService)
        {
            _messageService = messageService;
            _userService = userService;
        }
        public IActionResult CreateMessage(string receiverId, string content, string threadId)
        {
            PrivateMessageViewModel message = new PrivateMessageViewModel();

            message.Id = Guid.NewGuid().ToString();
            message.From = _userService.GetCurrentUser(User.Identity.Name).Username;
            message.Created = DateTime.Now;
            message.receiverId = receiverId;
            message.Content = content;

            _messageService.CreatePrivateMessage(message);

            return RedirectToAction("ShowPosts", "Post", new { threadId });
        }

        public IActionResult CreateMessage2(string receiverId, string content)
        {
            PrivateMessageViewModel message = new PrivateMessageViewModel();

            message.Id = Guid.NewGuid().ToString();
            message.From = _userService.GetCurrentUser(User.Identity.Name).Username;
            message.Created = DateTime.Now;
            message.receiverId = receiverId;
            message.Content = content;

            _messageService.CreatePrivateMessage(message);

            return RedirectToAction("Profile", "User");
        }

        public IActionResult DeleteMessage(string id)
        {

            _messageService.DeletePrivateMessage(id);

            return RedirectToAction("Profile", "User");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumDataAccess;
using ForumDomain;
using ForumWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWeb.Controllers
{
    public class ProfileController : Controller
    {
        private IUserRepository _userRepository;
        public ProfileController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Details(int id)
        {
            User user = _userRepository.GetUserById(id);
            UserViewModel viewUser = new UserViewModel();
            viewUser.Id = user.Id;
            viewUser.FirstName = user.FirstName;
            viewUser.LastName = user.LastName;
            viewUser.UserName = user.UserName;
            viewUser.Email = user.Email;
            viewUser.Password = user.Password;
            viewUser.Url = user.Url;
            return View(viewUser);
        }
    }
}
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
    public class LoginController : Controller
    {
        private IUserRepository _userRepository;
        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(UserViewModel user)
        {
            List<User> users = _userRepository.GetAllUsers().ToList();
            var check = users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if(check != null)
            {
                return RedirectToAction("Index", "Home",new { id = check.Id});
            }
            return RedirectToAction("Index", "Login");

        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
                _userRepository.AddUser(user);
                return Redirect("/Home/Index");
        }
    }
}
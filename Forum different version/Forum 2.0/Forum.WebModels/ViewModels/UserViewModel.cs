using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.WebModels.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime Joined { get; set; }
        public bool IsItOnline { get; set; } = false;
        public bool IsItSuspended { get; set; } = false;
        public string Avatar { get; set; }
        public List<PostViewModel> Posts { get; set; }
    }
}

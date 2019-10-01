using System;
using System.Collections.Generic;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime Joined { get; set; } = DateTime.Now.Date;
    }
}

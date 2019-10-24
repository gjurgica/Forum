using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DomainClasses.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime Joined { get; set; }
        public bool IsItOnline { get; set; } = false;
        public bool IsItSuspended { get; set; } = false;
        public string Avatar { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<PrivateMessage> Messages { get; set; }
        public virtual IEnumerable<Alert> Alerts { get; set; }
    }
}

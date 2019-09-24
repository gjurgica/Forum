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
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}

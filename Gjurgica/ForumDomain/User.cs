using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForumDomain
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Joined { get; set; }
        public bool IsItOnline { get; set; } = false;


        public virtual IEnumerable<Thread> Threads { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<PostReply> PostReplays { get; set; }
    }
}

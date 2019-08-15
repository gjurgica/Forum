using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWeb.Models
{
    public class OneForumUserViewModel
    {
        public ForumViewModel Forum { get; set; }
        public UserViewModel User { get; set; }
    }
}

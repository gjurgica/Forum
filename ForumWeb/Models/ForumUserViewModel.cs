using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWeb.Models
{
    public class ForumUserViewModel
    {
        public IEnumerable<ForumViewModel> Forums { get; set; }
        public UserViewModel User { get; set; }
    }
}

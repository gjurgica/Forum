using ForumDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWeb.Models
{
    public class TopicViewModel
    {
        public IEnumerable<PostViewModel> Posts { get; set; }
        public ForumViewModel Forum { get; set; }
    }
}

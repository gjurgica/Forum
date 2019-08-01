using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWeb.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        public string DatePosted { get; set; }

        public ForumViewModel Forum { get; set; }

        public int RepliesCount { get; set; }
    }
}

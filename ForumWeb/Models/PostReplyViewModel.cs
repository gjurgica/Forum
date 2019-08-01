using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWeb.Models
{
    public class PostReplyViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        public string AuthorImageUrl { get; set; }
        public string DatePosted { get; set; }
        public int PostId { get; set; }
    }
}

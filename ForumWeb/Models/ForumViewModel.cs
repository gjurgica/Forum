using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWeb.Models
{
    public class ForumViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Created { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }

    }
}

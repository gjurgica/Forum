using System;
using System.Collections.Generic;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class ForumViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }

        public UserViewModel User { get; set; }
        public List<PostViewModel> Posts { get; set; }
    }
}

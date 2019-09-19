using System;
using System.Collections.Generic;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public UserViewModel User { get; set; }
        public ForumViewModel Forum { get; set; }
        public List<PostReplyViewModel> Replies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class PostReplyViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public UserViewModel User { get; set; }
        public PostViewModel Post { get; set; }
    }
}

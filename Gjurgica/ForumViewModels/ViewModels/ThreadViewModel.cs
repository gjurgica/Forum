using System;
using System.Collections.Generic;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class ThreadViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }

        public CategoryViewModel Category { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}

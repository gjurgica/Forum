using System;
using System.Collections.Generic;
using System.Text;

namespace ForumViewModels.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public virtual IEnumerable<ThreadViewModel> Threads { get; set; }
    }
}

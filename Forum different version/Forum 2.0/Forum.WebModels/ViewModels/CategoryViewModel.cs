using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.WebModels.ViewModels
{
    public class CategoryViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public virtual IEnumerable<ThreadViewModel> Threads { get; set; }
    }
}

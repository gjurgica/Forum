using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.WebModels.ViewModels
{
    public class ThreadViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string CategoryId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.WebModels.ViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public int ThreadId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

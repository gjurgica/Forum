using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.WebModels.ViewModels
{
    public class PrivateMessageViewModel
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string From { get; set; }
        public string receiverId { get; set; }
    }
}

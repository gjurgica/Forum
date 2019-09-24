using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DomainClasses.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public virtual IEnumerable<Thread> Threads { get; set; }
    }
}

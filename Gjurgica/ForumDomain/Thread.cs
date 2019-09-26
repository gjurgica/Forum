using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForumDomain
{
    public class Thread
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual Category Category { get; set; }
    }
}

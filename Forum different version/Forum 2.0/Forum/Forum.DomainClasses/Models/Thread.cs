using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Forum.DomainClasses.Models
{
    public class Thread
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CategoryId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public virtual Category Category { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}

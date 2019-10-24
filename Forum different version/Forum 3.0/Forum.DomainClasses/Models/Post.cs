using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Forum.DomainClasses.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public string ThreadId { get; set; }
        public virtual Thread Thread { get; set; }
    }
}

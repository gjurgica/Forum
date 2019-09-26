using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForumDomain
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int? ThreadId { get; set; }
        public string UserId { get; set; }

        public virtual User User { get; set; }
        [ForeignKey("ThreadId")]
        public virtual Thread Thread { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}

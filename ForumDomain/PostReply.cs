using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForumDomain
{
    public class PostReply
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        public int PostId { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}

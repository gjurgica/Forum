﻿using System;
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
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int ForumId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual List<PostReply> Replies{ get; set; }
    }
}
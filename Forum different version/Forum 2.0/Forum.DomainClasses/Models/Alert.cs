using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Forum.DomainClasses.Models
{
    public class Alert
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string PostId { get; set; }
        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        
    }
}

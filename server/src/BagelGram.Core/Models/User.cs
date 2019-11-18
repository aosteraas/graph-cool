using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BagelGram.Core.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
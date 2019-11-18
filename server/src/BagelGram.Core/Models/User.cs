using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BagelGram.Core.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
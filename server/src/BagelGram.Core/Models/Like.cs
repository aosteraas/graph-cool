using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BagelGram.Core.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ImageId { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(nameof(ImageId))]
        public virtual Image Image { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
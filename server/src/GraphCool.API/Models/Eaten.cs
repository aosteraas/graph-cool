using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphCool.API.Models
{
    public class Eaten
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int MealId { get; set; }
        public DateTime Consumed { get; set; }

        [ForeignKey(nameof(PersonId))]
        public virtual Person Person { get; set; }

        [ForeignKey(nameof(MealId))]
        public virtual Meal Meal { get; set; }
    }
}
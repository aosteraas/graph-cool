using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphCool.API.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public ICollection<Eaten> Eaten { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphCool.API.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Eaten> Eaten { get; set; }
    }
}
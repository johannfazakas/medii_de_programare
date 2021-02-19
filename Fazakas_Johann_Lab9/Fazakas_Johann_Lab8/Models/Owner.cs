using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fazakas_Johann_Lab8.Models
{
    public class Owner
    {
        public Owner()
        {
        }

        public int ID { get; set; }

        [Display(Name = "Proprietar")]
        public string Name { get; set; }

        public ICollection<Guitar> Guitars { get; set; }
    }
}

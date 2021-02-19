using System;
using System.ComponentModel.DataAnnotations;

namespace Fazakas_Johann_Lab8.Models
{
    public class Guitar
    {
        public Guitar()
        {
        }

        public int ID { get; set; }
        [Display(Name = "Producator")]
        public string Brand { get; set; }
        [Display(Name = "Nume")]
        public string Name { get; set; }
        [Display(Name = "Culoare")]
        public string Color { get; set; }
        [Display(Name = "Pret")]
        public decimal Price { get; set; }
    }
}

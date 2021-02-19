using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display(Name = "Data crearii")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public int OwnerID { get; set; }

        [Display(Name = "Proprietar")]
        public Owner Owner { get; set; }

        public ICollection<GuitarTag> GuitarTags { get; set; }
    }
}

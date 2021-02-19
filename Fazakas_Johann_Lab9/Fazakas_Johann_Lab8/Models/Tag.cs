using System;
using System.Collections.Generic;

namespace Fazakas_Johann_Lab8.Models
{
    public class Tag
    {
        public Tag()
        {
        }

        public int ID { get; set; }
        public string TagName { get; set; }
        public ICollection<GuitarTag> GuitarTags { get; set; }
    }
}

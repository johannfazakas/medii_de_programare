using System;
namespace Fazakas_Johann_Lab8.Models
{
    public class GuitarTag
    {
        public GuitarTag()
        {
        }

        public int ID { get; set; }

        public int GuitarId { get; set; }

        public int Guitar { get; set; }

        public int TagId { get; set; }

        public int Tag { get; set; }
    }
}

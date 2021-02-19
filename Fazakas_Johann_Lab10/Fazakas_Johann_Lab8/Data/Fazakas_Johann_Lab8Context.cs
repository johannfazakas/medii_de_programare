using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fazakas_Johann_Lab8.Models;

namespace Fazakas_Johann_Lab8.Data
{
    public class Fazakas_Johann_Lab8Context : DbContext
    {
        public Fazakas_Johann_Lab8Context (DbContextOptions<Fazakas_Johann_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Fazakas_Johann_Lab8.Models.Guitar> Guitar { get; set; }

        public DbSet<Fazakas_Johann_Lab8.Models.Owner> Owner { get; set; }

        public DbSet<Fazakas_Johann_Lab8.Models.Tag> Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fazakas_Johann_Lab8.Data;
using Fazakas_Johann_Lab8.Models;

namespace Fazakas_Johann_Lab8.Pages.Guitars
{
    public class IndexModel : PageModel
    {
        private readonly Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context _context;

        public IndexModel(Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context context)
        {
            _context = context;
        }

        public IList<Guitar> Guitar { get;set; }

        public async Task OnGetAsync()
        {
            Guitar = await _context.Guitar
                .Include(g => g.Owner)
                .ToListAsync();
        }
    }
}

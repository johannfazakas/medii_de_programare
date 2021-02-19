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
    public class DetailsModel : PageModel
    {
        private readonly Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context _context;

        public DetailsModel(Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context context)
        {
            _context = context;
        }

        public Guitar Guitar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guitar = await _context.Guitar
                .Include(g => g.Owner)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Guitar == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

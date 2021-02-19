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
    public class DeleteModel : PageModel
    {
        private readonly Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context _context;

        public DeleteModel(Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Guitar Guitar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guitar = await _context.Guitar.FirstOrDefaultAsync(m => m.ID == id);

            if (Guitar == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guitar = await _context.Guitar.FindAsync(id);

            if (Guitar != null)
            {
                _context.Guitar.Remove(Guitar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fazakas_Johann_Lab8.Data;
using Fazakas_Johann_Lab8.Models;

namespace Fazakas_Johann_Lab8.Pages.Owners
{
    public class DetailsModel : PageModel
    {
        private readonly Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context _context;

        public DetailsModel(Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context context)
        {
            _context = context;
        }

        public Owner Owner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Owner = await _context.Owner.FirstOrDefaultAsync(m => m.ID == id);

            if (Owner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

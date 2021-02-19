using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fazakas_Johann_Lab8.Data;
using Fazakas_Johann_Lab8.Models;

namespace Fazakas_Johann_Lab8.Pages.Owners
{
    public class CreateModel : PageModel
    {
        private readonly Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context _context;

        public CreateModel(Fazakas_Johann_Lab8.Data.Fazakas_Johann_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Owner Owner { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Owner.Add(Owner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

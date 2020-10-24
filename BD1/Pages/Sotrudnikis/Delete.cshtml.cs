using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD1.Data;
using DiBi.Models;

namespace BD1.Pages.Sotrudnikis
{
    public class DeleteModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public DeleteModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Sotrudniki Sotrudniki { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sotrudniki = await _context.Sotrudniki.FirstOrDefaultAsync(m => m.ID == id);

            if (Sotrudniki == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sotrudniki = await _context.Sotrudniki.FindAsync(id);

            if (Sotrudniki != null)
            {
                _context.Sotrudniki.Remove(Sotrudniki);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD1.Data;
using DiBi.Models;

namespace BD1.Pages.Dop_yslygis
{
    public class DeleteModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public DeleteModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Dop_yslygi Dop_yslygi { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dop_yslygi = await _context.Dop_yslygi.FirstOrDefaultAsync(m => m.ID == id);

            if (Dop_yslygi == null)
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

            Dop_yslygi = await _context.Dop_yslygi.FindAsync(id);

            if (Dop_yslygi != null)
            {
                _context.Dop_yslygi.Remove(Dop_yslygi);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

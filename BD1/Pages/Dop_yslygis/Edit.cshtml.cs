using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BD1.Data;
using DiBi.Models;

namespace BD1.Pages.Dop_yslygis
{
    public class EditModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public EditModel(BD1.Data.BD1Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dop_yslygi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Dop_yslygiExists(Dop_yslygi.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Dop_yslygiExists(long id)
        {
            return _context.Dop_yslygi.Any(e => e.ID == id);
        }
    }
}

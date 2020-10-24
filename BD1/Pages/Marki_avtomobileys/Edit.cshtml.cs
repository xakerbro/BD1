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

namespace BD1.Pages.Marki_avtomobileys
{
    public class EditModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public EditModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Marki_avtomobiley Marki_avtomobiley { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Marki_avtomobiley = await _context.Marki_avtomobiley.FirstOrDefaultAsync(m => m.ID == id);

            if (Marki_avtomobiley == null)
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

            _context.Attach(Marki_avtomobiley).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Marki_avtomobileyExists(Marki_avtomobiley.ID))
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

        private bool Marki_avtomobileyExists(long id)
        {
            return _context.Marki_avtomobiley.Any(e => e.ID == id);
        }
    }
}

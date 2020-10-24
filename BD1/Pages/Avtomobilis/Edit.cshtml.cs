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

namespace BD1.Pages.Avtomobilis
{
    public class EditModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public EditModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Avtomobili Avtomobili { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Avtomobili = await _context.Avtomobili.FirstOrDefaultAsync(m => m.ID == id);

            if (Avtomobili == null)
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

            _context.Attach(Avtomobili).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvtomobiliExists(Avtomobili.ID))
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

        private bool AvtomobiliExists(long id)
        {
            return _context.Avtomobili.Any(e => e.ID == id);
        }
    }
}

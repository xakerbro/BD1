using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD1.Data;
using DiBi.Models;

namespace BD1.Pages.Marki_avtomobileys
{
    public class DetailsModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public DetailsModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

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
    }
}

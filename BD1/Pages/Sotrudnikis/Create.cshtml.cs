﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BD1.Data;
using DiBi.Models;

namespace BD1.Pages.Sotrudnikis
{
    public class CreateModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public CreateModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sotrudniki Sotrudniki { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sotrudniki.Add(Sotrudniki);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

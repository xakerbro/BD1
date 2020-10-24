using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD1.Data;
using DiBi.Models;

namespace BD1.Pages.Doljnostis
{
    public class IndexModel : PageModel
    {
        private readonly BD1.Data.BD1Context _context;

        public IndexModel(BD1.Data.BD1Context context)
        {
            _context = context;
        }

        public IList<Doljnosti> Doljnosti { get;set; }

        public async Task OnGetAsync()
        {
            Doljnosti = await _context.Doljnosti.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Documents_AuthToProcesPers
{
    public class DetailsModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public DetailsModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public DocumentBase AuthorizationToProcesPersonalDataDocument { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuthorizationToProcesPersonalDataDocument = await _context.DocumentBases
                .Include(a => a.Owner).FirstOrDefaultAsync(m => m.Id == id);

            if (AuthorizationToProcesPersonalDataDocument == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

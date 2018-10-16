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
        private readonly Rejupo.Models.FakeDbContext _context;

        public DetailsModel(Rejupo.Models.FakeDbContext context)
        {
            _context = context;
        }

        public AuthorizationToProcesPersonalDataDocument AuthorizationToProcesPersonalDataDocument { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuthorizationToProcesPersonalDataDocument = await _context.AuthorizationToProcesPersonalDataDocuments
                .Include(a => a.LastChanged)
                .Include(a => a.Owner).FirstOrDefaultAsync(m => m.Id == id);

            if (AuthorizationToProcesPersonalDataDocument == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Documents_AuthToProcesPers
{
    public class CreateModel : PageModel
    {
        private readonly Rejupo.Models.FakeDbContext _context;

        public CreateModel(Rejupo.Models.FakeDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LastChangedId"] = new SelectList(_context.Set<Log>(), "Id", "Id");
        ViewData["OwnerId"] = new SelectList(_context.Employee, "ControlNumber", "ControlNumber");
            return Page();
        }

        [BindProperty]
        public AuthorizationToProcesPersonalDataDocument AuthorizationToProcesPersonalDataDocument { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AuthorizationToProcesPersonalDataDocuments.Add(AuthorizationToProcesPersonalDataDocument);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
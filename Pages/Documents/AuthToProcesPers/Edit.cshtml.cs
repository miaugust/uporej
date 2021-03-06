using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Documents_AuthToProcesPers
{
    public class EditModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public EditModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["LastChangedId"] = new SelectList(_context.Set<Log>(), "Id", "Id");
           ViewData["OwnerId"] = new SelectList(_context.Employees, "ControlNumber", "ControlNumber");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AuthorizationToProcesPersonalDataDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorizationToProcesPersonalDataDocumentExists(AuthorizationToProcesPersonalDataDocument.Id))
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

        private bool AuthorizationToProcesPersonalDataDocumentExists(int id)
        {
            return _context.DocumentBases.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rejupo.Data;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Admin_PersonalDataAuthorizationScopes
{
    public class EditModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public EditModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PersonalDataAuthorizationScope PersonalDataAuthorizationScope { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonalDataAuthorizationScope = await _context.PersonalDataAuthorizationScopes.FirstOrDefaultAsync(m => m.Id == id);

            if (PersonalDataAuthorizationScope == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PersonalDataAuthorizationScope).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalDataAuthorizationScopeExists(PersonalDataAuthorizationScope.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            await LogWriter.WritetoDbAsync(_context, HttpContext.User.Identity.Name,
                 $"Zmieniono nazwę upoważnienia, Id: {PersonalDataAuthorizationScope.Id}, Nazwa: {PersonalDataAuthorizationScope.Scope}");

            return RedirectToPage("./Index");
        }

        private bool PersonalDataAuthorizationScopeExists(int id)
        {
            return _context.PersonalDataAuthorizationScopes.Any(e => e.Id == id);
        }
    }
}

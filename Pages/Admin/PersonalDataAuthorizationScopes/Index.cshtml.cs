using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Data;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Admin_PersonalDataAuthorizationScopes
{
    public class IndexModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public IndexModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<PersonalDataAuthorizationScope> PersonalDataAuthorizationScope { get;set; }

        public async Task OnGetAsync()
        {
            PersonalDataAuthorizationScope = await _context.PersonalDataAuthorizationScopes.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var scope = await _context.PersonalDataAuthorizationScopes.FindAsync(id);

            if (scope != null)
            {
                _context.PersonalDataAuthorizationScopes.Remove(scope);
                await _context.SaveChangesAsync();
                await LogWriter.WritetoDbAsync(_context, HttpContext.User.Identity.Name,
                 $"Usunięto zdefiniowany rodzaj upoważnienia, Id: {scope.Id}, Nazwa: {scope.Scope}");
            }

            return RedirectToPage();
        }
    }
}

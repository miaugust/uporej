using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rejupo.Data;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Admin_PersonalDataAuthorizationScopes
{
    public class CreateModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public CreateModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AuthorizationScope PersonalDataAuthorizationScope { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AuthorizationScopes.Add(PersonalDataAuthorizationScope);
            await _context.SaveChangesAsync();
            await LogWriter.WritetoDbAsync(_context, HttpContext.User.Identity.Name,
                 $"Dodano nowy rodzaj upoważnienia, Id: {PersonalDataAuthorizationScope.Id}, Nazwa: {PersonalDataAuthorizationScope.Scope}");

            return RedirectToPage("./Index");
        }
    }
}
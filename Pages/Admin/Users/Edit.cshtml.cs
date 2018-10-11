using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rejupo.Areas.Identity.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Users
{
    public class EditModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public EditModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RejupoUser RejupoUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RejupoUser = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (RejupoUser == null)
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

            _context.Attach(RejupoUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RejupoUserExists(RejupoUser.Id))
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

        private bool RejupoUserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Areas.Identity.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Users
{
    public class DeleteModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public DeleteModel(Rejupo.Models.AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RejupoUser = await _context.Users.FindAsync(id);

            if (RejupoUser != null)
            {
                _context.Users.Remove(RejupoUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

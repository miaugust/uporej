using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Divisions
{
    [Authorize(Roles = SD.SuperAdmin)]
    public class DeleteModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public DeleteModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Division Division { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Division = await _context.Divisions.FirstOrDefaultAsync(m => m.Id == id);

            if (Division == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Division = await _context.Divisions.FindAsync(id);

            if (Division != null)
            {
                _context.Divisions.Remove(Division);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

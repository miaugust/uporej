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
    public class DetailsModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public DetailsModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

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
    }
}

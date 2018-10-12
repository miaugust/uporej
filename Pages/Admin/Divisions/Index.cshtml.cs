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
    public class IndexModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public IndexModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Division> Division { get;set; }

        public async Task OnGetAsync()
        {
            Division = await _context.Divisions.ToListAsync();
        }
    }
}

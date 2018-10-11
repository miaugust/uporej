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
    public class IndexModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public IndexModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<RejupoUser> RejupoUser { get;set; }

        public async Task OnGetAsync()
        {
            RejupoUser = await _context.Users.ToListAsync();
        }
    }
}

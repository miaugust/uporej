using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Areas.Identity.Data;
using Rejupo.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Users
{
    public class IndexModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;
        private readonly UserManager<RejupoUser> _userManager;

        public IndexModel(Rejupo.Models.AppDbContext context, UserManager<RejupoUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public IList<RejupoUser> RejupoUser { get;set; }
        public UserManager<RejupoUser> UserManager { get; set; }



        public async Task OnGetAsync()
        {
            RejupoUser = await _context.Users.ToListAsync();
            UserManager = _userManager;
            
        }
    }
}

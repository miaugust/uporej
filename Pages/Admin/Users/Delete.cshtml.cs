using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rejupo.Areas.Identity.Data;
using Rejupo.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Users
{
    public class DeleteModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;
        private readonly UserManager<RejupoUser> _userManager;

        public DeleteModel(Rejupo.Models.AppDbContext context, UserManager<RejupoUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public RejupoUser RejupoUser { get; set; }
        [BindProperty]
        public string RejupoUserID { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RejupoUser = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            RejupoUserID = RejupoUser.Id;

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

            //RejupoUser = await _context.Users.FindAsync(id);
            RejupoUser = await _userManager.FindByIdAsync(id);

            if (RejupoUser != null)
            {
                await _userManager.DeleteAsync(RejupoUser);
                await LogWriter.WritetoDbAsync(_context, HttpContext.User.Identity.Name, "Usunięcie użytkownika " + RejupoUser.UserName);
            }

            return RedirectToPage("./Index");
        }
    }
}

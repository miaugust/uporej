using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rejupo.Areas.Identity.Data;
using Rejupo.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Users
{
    public class EditModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<RejupoUser> _userManager;

        public EditModel(Rejupo.Models.AppDbContext context,
                         RoleManager<IdentityRole> roleManager,
                         UserManager<RejupoUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            Input = new InputModel();
        }
        public RejupoUser RejupoUser { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public string RejupoUserID { get; set; }

        public class InputModel
        {
            [Display(Name = "Super Administrator")]
            public bool IsSuperAdmin { get; set; }
            [Display(Name = "Administrator")]
            public bool IsAdmin { get; set; }
            [Display(Name = "Użytkownik")]
            public bool IsUser { get; set; }
        }
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
            Input.IsSuperAdmin = await _userManager.IsInRoleAsync(RejupoUser, SD.SuperAdmin);
            Input.IsAdmin = await _userManager.IsInRoleAsync(RejupoUser, SD.Admin);
            Input.IsUser = await _userManager.IsInRoleAsync(RejupoUser, SD.User);
            RejupoUserID = RejupoUser.Id;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            RejupoUser user = await _userManager.FindByIdAsync(RejupoUserID);
            
            if (Input.IsAdmin)
                await _userManager.AddToRoleAsync(user, SD.Admin);
            else
                await _userManager.RemoveFromRoleAsync(user, SD.Admin);
            if (Input.IsUser)
                await _userManager.AddToRoleAsync(user, SD.User);
            else
                await _userManager.RemoveFromRoleAsync(user, SD.User);
            if (Input.IsSuperAdmin)
                await _userManager.AddToRoleAsync(user, SD.SuperAdmin);
            else
                await _userManager.RemoveFromRoleAsync(user, SD.SuperAdmin);

            await LogWriter.WritetoDbAsync(_context, HttpContext.User.Identity.Name,
             $"Zmiana ról użytkownika {user.UserName} {SD.SuperAdmin} {Input.IsSuperAdmin} {SD.Admin} {Input.IsAdmin} {SD.User} {Input.IsUser}");

            //_context.Attach(RejupoUser).State = EntityState.Modified;

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

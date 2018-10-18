using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rejupo.Areas.Identity.Data;
using Rejupo.Data;
using Rejupo.Models;

namespace Rejupo.Pages_Employees
{
    [Authorize(Policy = SD.Admin)]
    public class CreateModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;
        private readonly UserManager<RejupoUser> _userManager;

        public CreateModel(Rejupo.Models.AppDbContext context, UserManager<RejupoUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        [BindProperty]
        public Employee Employee { get; set; }
        [BindProperty]
        public string Message { get; set; }

        public SelectList Divisions { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var list = await _context.Divisions.Select(d => d.Abbreviation).ToListAsync();
            if (User.IsInRole(SD.Admin))
            {
                var user = await _userManager.GetUserAsync(User);
                list = list.Where(d => d == user.Division).ToList();
            }
            Divisions = new SelectList(list);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (_context.Employees.Find(Employee.ControlNumber) != null)
            {
                Message = $"Pracownik o numerze kontrolnym {Employee.ControlNumber} już istnieje!";
                return Page();
            }
            
            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();
            await LogWriter.WritetoDbAsync(_context, User.Identity.Name, $"Dodany pracownik, Nr kontrolny: {Employee.ControlNumber}");

            return RedirectToPage("./Index");
        }
    }
}
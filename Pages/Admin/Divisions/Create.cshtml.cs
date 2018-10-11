using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rejupo.Models;

namespace Rejupo.Pages_Admin_Divisions
{
    public class CreateModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public CreateModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Division Division { get; set; }
        [BindProperty]
        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            if(_context.Divisions.Find(Division.Id) == null)
            {
                _context.Divisions.Add(Division);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            else
            {
                Message = "Podany numer już istnieje!";
                return Page();
            }


            
        }
    }
}
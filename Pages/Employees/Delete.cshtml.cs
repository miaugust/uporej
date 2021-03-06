using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Models;

namespace Rejupo.Pages_Employees
{
    public class DeleteModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public DeleteModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees
                .Include(e=>e.Document)
                .ThenInclude(d=>d.Document_Scope)
                .FirstOrDefaultAsync(m => m.ControlNumber == id);

            if (Employee == null)
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

            Employee = await _context.Employees
                .Include(e=>e.Document)
                .ThenInclude(d=>d.Document_Scope)
                .FirstOrDefaultAsync(m => m.ControlNumber == id);

            if (Employee != null)
            {
                if (Employee.Document != null)
                {
                    _context.DocumentBases.Remove(Employee.Document);
                }
                _context.Employees.Remove(Employee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

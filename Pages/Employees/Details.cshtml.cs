using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Employees
{
    public class DetailsModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;

        public DetailsModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }
        public DocumentBase DocumentBase { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees.Include(e => e.Document).
            FirstOrDefaultAsync(m => m.ControlNumber == id);

            if (Employee == null)
            {
                return NotFound();
            }
            DocumentBase = Employee.Document;
            return Page();
        }
    }
}

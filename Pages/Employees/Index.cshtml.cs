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
    public class IndexModel : PageModel
    {
        private readonly Rejupo.Models.FakeDbContext _context;

        public IndexModel(Rejupo.Models.FakeDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}

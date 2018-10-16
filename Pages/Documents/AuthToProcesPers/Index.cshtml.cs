using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Documents_AuthToProcesPers
{
    public class IndexModel : PageModel
    {
        private readonly Rejupo.Models.FakeDbContext _context;

        public IndexModel(Rejupo.Models.FakeDbContext context)
        {
            _context = context;
        }

        public IList<AuthorizationToProcesPersonalDataDocument> AuthorizationToProcesPersonalDataDocument { get;set; }

        public async Task OnGetAsync()
        {
            AuthorizationToProcesPersonalDataDocument = await _context.AuthorizationToProcesPersonalDataDocuments
                .Include(a => a.LastChanged)
                .Include(a => a.Owner).ToListAsync();
        }
    }
}

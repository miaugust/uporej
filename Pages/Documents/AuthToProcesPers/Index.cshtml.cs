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
        private readonly Rejupo.Models.AppDbContext _context;

        public IndexModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<DocumentBase> AuthorizationToProcesPersonalDataDocument { get;set; }

        public void OnGet()
        {
            AuthorizationToProcesPersonalDataDocument = _context.DocumentBases.ToList();
        }
    }
}

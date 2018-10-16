using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rejupo.Data;
using Rejupo.Models;
using Rejupo.Models.Docs;

namespace Rejupo.Pages_Documents_AuthToProcesPers
{
    [Authorize(Policy = SD.Admin)]
    public class CreateModel : PageModel
    {
        private readonly Rejupo.Models.AppDbContext _context;



        public CreateModel(Rejupo.Models.AppDbContext context)
        {
            _context = context;
            DocumentInputData = new DocumentInputData();
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees.FindAsync(id);

            if (Employee == null)
            {
                return NotFound();
            }
    
            DocumentInputData.Scopes = _context.PersonalDataAuthorizationScopes.Select(s => s.Scope).ToList();
            DocumentInputData.IsScopeSelected = (new bool[DocumentInputData.Scopes.Count]).ToList();
            DocumentInputData.ValidTo = null;
            DocumentInputData.DateCreated = DateTime.Now;
            DocumentInputData.Name = "Upoważnienie do przetwarzania danych";
            DocumentInputData.OwnerId = Employee.ControlNumber;
            DocumentInputData.FirstName = Employee.FirstName;
            DocumentInputData.LastName = Employee.LastName;
            return Page();
        }

        [BindProperty]
        public DocumentInputData DocumentInputData { get; set; }
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.AuthorizationToProcesPersonalDataDocuments.Add(AuthorizationToProcesPersonalDataDocument);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
    public class DocumentInputData
    {
        [Display(Name = "Nazwa dokumentu")]
        public string Name { get; set; }
        [Display(Name = "Numer kontrolny pracownika")]
        public string OwnerId { get; set; }
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [DataType(DataType.Date), Display(Name = "Data Utworzenia")]
        public DateTime DateCreated { get; set; }
        [DataType(DataType.Date), Display(Name = "Ważne do")]
        public DateTime? ValidTo { get; set; }
        public List<string> Scopes { get; set; }
        public List<bool> IsScopeSelected { get; set; }
    }
}
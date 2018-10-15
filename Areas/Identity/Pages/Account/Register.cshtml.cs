using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rejupo.Areas.Identity.Data;
using Rejupo.Data;
using Rejupo.Models;

namespace Rejupo.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<RejupoUser> _signInManager;
        private readonly UserManager<RejupoUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly AppDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<RejupoUser> userManager,
            SignInManager<RejupoUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            AppDbContext db,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _db = db;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public SelectList Divisions { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Imię")]
            public string FirstName { get; set; }
            [Required]
            [Display(Name = "Nazwisko")]
            public string LastName { get; set; }
            [Required]
            [Display(Name = "Oddział")]
            public string Division { get; set; }
            [Required, Phone, Display(Name = "Telefon")]
            public string Phone {get; set;}
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "{0} musi posiadać przynajmniej {2} znaków.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Hasło")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Powtórzone hasło")]
            [Compare("Password", ErrorMessage = "Hasła nie są zgodne.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            var divisions = await _db.Divisions.Select(d=> d.Abbreviation).ToListAsync();
            if(divisions.Count == 0)
                divisions.Add("--");
            Divisions = new SelectList(divisions);
            

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new RejupoUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Division = Input.Division,
                    PhoneNumber = Input.Phone
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    // Tworzenie (w razie potrzeby) wpisów do tabeli aspnetroles
                    if (!await _roleManager.RoleExistsAsync(SD.SuperAdmin))
                        await _roleManager.CreateAsync(new IdentityRole(SD.SuperAdmin));

                    if (!await _roleManager.RoleExistsAsync(SD.Admin))
                        await _roleManager.CreateAsync(new IdentityRole(SD.Admin));

                    if (!await _roleManager.RoleExistsAsync(SD.User))
                        await _roleManager.CreateAsync(new IdentityRole(SD.User));


                    // nadanie pierwszemu rejestrującemu się użytkownikowi roli superadmin
                    if (_db.Users.Count() == 1)
                        await _userManager.AddToRoleAsync(user, SD.SuperAdmin);
                    
                    else
                        await _userManager.AddToRoleAsync(user, SD.User);
                    
                    
                    _logger.LogInformation("User created a new account with password.");
                    await LogWriter.WritetoDbAsync(_db, user.UserName, "Rejestracja użytkownika.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}

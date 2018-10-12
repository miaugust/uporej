using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rejupo.Areas.Identity.Data;

namespace Rejupo.Pages
{
    
    public class PrivacyModel : PageModel
    {
        private readonly UserManager<RejupoUser> _userManager;

        public PrivacyModel(UserManager<RejupoUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public RejupoUser user { get; set; }

        public void OnGet()
        {
            var user = HttpContext.User;
            ViewData["UserName"] = user.Identity.Name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rejupo.Areas.Identity.Data;
using Rejupo.Models.Docs;

namespace Rejupo.Models
{
    /* Stworzony w celu uniknięcia problemów przy automatycznej generacji kodu */
    public class FakeDbContext : DbContext
    {
        public FakeDbContext(DbContextOptions<FakeDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Rejupo.Areas.Identity.Data.RejupoUser> RejupoUser { get; set; }
        public DbSet<Rejupo.Models.Docs.PersonalDataAuthorizationScope> PersonalDataAuthorizationScope { get; set; }
    }
}

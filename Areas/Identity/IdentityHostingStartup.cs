using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rejupo.Areas.Identity.Data;
using Rejupo.Models;

[assembly: HostingStartup(typeof(Rejupo.Areas.Identity.IdentityHostingStartup))]
namespace Rejupo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseMySql(context.Configuration.GetConnectionString("MySql")));

                services.AddDefaultIdentity<RejupoUser>()
                        .AddRoles<IdentityRole>()
                        .AddEntityFrameworkStores<AppDbContext>();
            });
        }
    }
}
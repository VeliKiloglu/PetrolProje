using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetrolProje.Areas.Identity.Data;
using PetrolProje.Data;

[assembly: HostingStartup(typeof(PetrolProje.Areas.Identity.IdentityHostingStartup))]
namespace PetrolProje.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PetrolProjeContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PetrolProjeContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                 })
                    .AddEntityFrameworkStores<PetrolProjeContext>();
            });
        }
    }
}
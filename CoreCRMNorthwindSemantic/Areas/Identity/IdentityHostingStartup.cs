using System;
using CoreCRMNorthwindSemantic.Areas.Identity.Data;
using CoreCRMNorthwindSemantic.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CoreCRMNorthwindSemantic.Areas.Identity.IdentityHostingStartup))]
namespace CoreCRMNorthwindSemantic.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CoreCRMNorthwindSemanticIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CoreCRMNorthwindSemanticIdentityContextConnection")));

                services.AddDefaultIdentity<CoreCRMNorthwindSemanticUser>()
                    .AddEntityFrameworkStores<CoreCRMNorthwindSemanticIdentityContext>();
            });
        }
    }
}
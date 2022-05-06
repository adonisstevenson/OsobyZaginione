using EnumsNET;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace OsobyZaginione.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole (Enums.Roles.SuperAdmin.ToString()))
        }
    }
}

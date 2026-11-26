namespace CourtSide.Data.Seeding
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    using static CourtSide.Common.RoleConstants;

    public static class IdentitySeeder
    {
        private static readonly string[] DefaultRoles =
        {
            UserRoleName,
            ManagerRoleName,
            AdminRoleName
        };

        public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
        {
            RoleManager<IdentityRole> roleManager = serviceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            foreach (string roleName in DefaultRoles)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(roleName));
                    if (!result.Succeeded)
                    {
                        throw new InvalidOperationException($"Role '{roleName}' could not be created.");
                    }
                }
            }
        }

        public static async Task SeedAdminUserAsync(
            IServiceProvider serviceProvider,
            string adminEmail,
            string adminPassword)
        {
            UserManager<IdentityUser> userManager = serviceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser? adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser != null)
            {
                return;
            }

            adminUser = new IdentityUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true
            };

            IdentityResult createResult = await userManager.CreateAsync(adminUser, adminPassword);
            if (!createResult.Succeeded)
            {
                throw new InvalidOperationException($"Admin user '{adminEmail}' could not be created.");
            }

            IdentityResult roleResult = await userManager.AddToRoleAsync(adminUser, AdminRoleName);
            if (!roleResult.Succeeded)
            {
                throw new InvalidOperationException($"Admin user '{adminEmail}' could not be added to '{AdminRoleName}'.");
            }
        }
    }
}
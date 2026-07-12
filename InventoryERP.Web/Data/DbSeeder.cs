using Microsoft.AspNetCore.Identity;
using InventoryERP.Data;

namespace InventoryERP.Web.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roleNames = { "Super Admin", "Administrator", "Inventory Staff", "Sales Staff" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var adminEmail = "admin@inventory.local";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new ApplicationUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(adminUser, "Admin@123");
                if (result.Succeeded) await userManager.AddToRoleAsync(adminUser, "Administrator");
            }

            // Create Super Admin
            var superAdminEmail = "superadmin@inventory.local";
            if (await userManager.FindByEmailAsync(superAdminEmail) == null)
            {
                var user = new ApplicationUser { UserName = superAdminEmail, Email = superAdminEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(user, "SuperAdmin@123");
                if (result.Succeeded) await userManager.AddToRoleAsync(user, "Super Admin");
            }

            // Create Inventory Staff
            var inventoryEmail = "inventory@inventory.local";
            if (await userManager.FindByEmailAsync(inventoryEmail) == null)
            {
                var user = new ApplicationUser { UserName = inventoryEmail, Email = inventoryEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(user, "Inventory@123");
                if (result.Succeeded) await userManager.AddToRoleAsync(user, "Inventory Staff");
            }

            // Create Sales Staff
            var salesEmail = "sales@inventory.local";
            if (await userManager.FindByEmailAsync(salesEmail) == null)
            {
                var user = new ApplicationUser { UserName = salesEmail, Email = salesEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(user, "Sales@123");
                if (result.Succeeded) await userManager.AddToRoleAsync(user, "Sales Staff");
            }
        }
    }
}

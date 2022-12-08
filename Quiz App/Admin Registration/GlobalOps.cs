using Microsoft.AspNetCore.Identity;

namespace Quiz_App.Admin_Registration
{
    public static class GlobalOps
    {
        public static async Task CreateApplicationAdministrator(IServiceProvider serviceProvider)
        {
            try
            {
                // retrive instances of the RoleManager and UserManager 
                //from the Dependency Container
                var roleManager = serviceProvider
                    .GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = serviceProvider
                    .GetRequiredService<UserManager<IdentityUser>>();

                IdentityResult result;
                // add a new Administrator role for the application
                var isRoleExist = await roleManager
                    .RoleExistsAsync("Admin");
                if (!isRoleExist)
                {
                    // create Administrator Role and add it in Database
                    result = await roleManager
                        .CreateAsync(new IdentityRole("Admin"));
                }

                // code to create a default user and add it to Administrator Role
                var user = await userManager
                    .FindByEmailAsync("pratham@gmail.com");
                if (user == null)
                {
                    var defaultUser = new IdentityUser()
                    {
                        UserName = "pratham@gmail.com",
                        Email = "pratham@gmail.com"
                    };
                    var regUser = await userManager
                        .CreateAsync(defaultUser, "pratham");
                    await userManager
                        .AddToRoleAsync(defaultUser, "Admin");
                }
            }
            catch (Exception ex)
            {
                var str = ex.Message;
            }

        }
    }
}

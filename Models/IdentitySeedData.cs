using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Models;

public static class IdentitySeedData
{
   private const string adminuser = "Admin";
    private const string adminPassword = "Admin_123";

    public static async void IdentitTestUser(IApplicationBuilder app)
    {
      
      var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<IdentityContext>();

      if(context.Database.GetAppliedMigrations().Any())
      {
       
       context.Database.Migrate();

      }

      var userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<AppUser>>();

      var user = await userManager.FindByNameAsync(adminuser);

      if(user==null)
      {

            user = new AppUser{
                FullName= "Yusuf Güneş",
                UserName= adminuser,
                Email= "ygunes@hotmail.com",
                PhoneNumber= "155"

            };

            await userManager.CreateAsync(user, adminPassword);

      }

    }
}


using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TodoAdvWeb.Server.Areas.Identity.Data;
using TodoAdvWeb.Server.Data;

namespace TodoAdvWeb.Server.Models
{
    public class SeedData
    {
        public static async Task EnsurePopulated(IServiceProvider services)
        {
            // get a handle to the context
            TodoContext context = services.GetService<TodoContext>();

            // check if the context is valid
            if (context == null)
            {
                throw new NullReferenceException("No Context available");
            }

            // check if there is data in the database
            if (context.Todos.Any())
            {
                // if there is, abort (we don't need to seed)
                return;
            } else
            {
                // get user manager servicer
                UserManager<TodoUser> userManager = services.GetService<UserManager<TodoUser>>();

                // check if the user manager exists
                if (userManager == null)
                {
                    throw new NullReferenceException("No User Manager Available.");
                }

                TodoUser user = new TodoUser
                {
                    UserName = "test",
                    Email = "test@test.com"
                };

                IdentityResult result = await userManager.CreateAsync(user, "Test123!");

                if (result.Succeeded)
                {
                    context.Todos.Add(new Todo
                    {
                        Description = "Buy Milk",
                        Completed = false,
                        OwnerId = user.Id
                    });

                    // save my changes
                    await context.SaveChangesAsync();
                } else
                {
                    throw new Exception("Failed to create user");
                }
            }
        }
    }
}

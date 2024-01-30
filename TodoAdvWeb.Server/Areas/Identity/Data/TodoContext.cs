using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoAdvWeb.Server.Areas.Identity.Data;
using TodoAdvWeb.Server.Models;

namespace TodoAdvWeb.Server.Data;

public class TodoContext : IdentityDbContext<TodoUser>
{

    public DbSet<Todo> Todos { get; set; }

    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        
        // for later: builder.Entity<Todo>().Navigation(t => t.Owner).AutoInclude();
    }
}

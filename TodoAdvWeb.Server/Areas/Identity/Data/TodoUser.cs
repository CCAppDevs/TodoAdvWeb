using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TodoAdvWeb.Server.Models;

namespace TodoAdvWeb.Server.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TodoUser class
public class TodoUser : IdentityUser
{
    public virtual ICollection<Todo> Todos { get; set; }
}


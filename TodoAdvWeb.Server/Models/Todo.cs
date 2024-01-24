using System.ComponentModel.DataAnnotations;
using TodoAdvWeb.Server.Areas.Identity.Data;

namespace TodoAdvWeb.Server.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        [Required]
        public TodoUser Owner { get; set; }
    }
}

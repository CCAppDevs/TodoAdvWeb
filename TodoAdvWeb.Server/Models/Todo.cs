using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using TodoAdvWeb.Server.Areas.Identity.Data;

namespace TodoAdvWeb.Server.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        [Required]
        [ForeignKey(nameof(TodoUser))]
        public string OwnerId { get; set; }
    }
}

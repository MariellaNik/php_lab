using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace WebApplication13.Models.DAL
{
    [Index(nameof(Name), IsUnique = true)]
    public class Major
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}

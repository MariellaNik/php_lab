using System.ComponentModel.DataAnnotations;
namespace WebApplication13.Models
{
    public class AddCourseViewModel
    {
        [Required]
        public int MajorId { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
    public class UpdateCourseViewModel
    {
        [Required]
        public int MajorId { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
}

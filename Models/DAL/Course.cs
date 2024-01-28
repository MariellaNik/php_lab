using System.ComponentModel.DataAnnotations;
namespace WebApplication13.Models.DAL
{
    public class Course
    {
        public int Id { get; set; }
        public int MajorId { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public virtual Major Major { get; set; }
    }
}
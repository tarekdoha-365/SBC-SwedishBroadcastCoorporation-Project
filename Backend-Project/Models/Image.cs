using System.ComponentModel.DataAnnotations;

namespace Backend_Project.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        
    }
}
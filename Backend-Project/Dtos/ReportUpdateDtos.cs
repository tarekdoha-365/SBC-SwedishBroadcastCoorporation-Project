using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Dtos
{
    public class ReportUpdateDtos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ReportType { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Published { get; set; }
        [Required]
        public bool Modified { get; set; }
        [Required]
        public bool IsExpired { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}

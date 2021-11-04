using System;
using System.ComponentModel.DataAnnotations;

namespace Backend_Project.Dtos
{
    public class ReportCreateDtos
    {
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
        [Required]
        public string ImagePath { get; set; }
    }
}